using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Controller
{
    class RootSearch : SearchBase, IFileManage
    {
        public RootSearch(Settings s)
        {
            _set = s;
            _res = new Model.Results();
        }

        public void MoveFile(System.IO.FileInfo file)
        {
            System.IO.FileInfo newfile = null;
            try
            {
                newfile = file.CopyTo(Set.TargetPath);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                this.Res.LogError(e.Message);
            }

            if (newfile != null)
            {
                this.Res.UpMoved(file.FullName, newfile.FullName);
                DeleteFile(file);
            }
            else
            {
                this.Res.LogError("Copy failed for unkown reasons.");
                SkipFile(file);
            }
        }

        public void DeleteFile(System.IO.FileInfo file)
        {
            try
            {
                file.Delete();
            }
            catch (UnauthorizedAccessException e)
            {
                this.Res.LogError(e.Message);
            }
        }

        public void SkipFile(System.IO.FileInfo file)
        {
            this.Res.UpSkipped(file.FullName);
        }

    }
}
