using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Controller
{
    class SearchManager : IFileManage
    {
        #region Association with Search class
        private SearchBase _search;

        public SearchManager()
        {
            _search = new SearchRecurse(this); // NOTE: change this type to instantiate a different search algorithm
        }
        #endregion

        #region IFileManage interface methods
        public void MoveFile(System.IO.FileInfo file)
        {
            System.IO.FileInfo newfile = null;
            try
            {
                string dest = Model.Settings.TargetPath + @"\" + file.Name;
                newfile = file.CopyTo(dest);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Model.Results.LogError(e.Message);
            }

            if (newfile != null)
            {
                Model.Results.UpMoved(file.FullName, newfile.FullName);
                DeleteFile(file);
            }
            else
            {
                Model.Results.LogError("Copy failed for unkown reasons.");
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
                Model.Results.LogError(e.Message);
            }
        }

        public void SkipFile(System.IO.FileInfo file)
        {
            Model.Results.UpSkipped(file.FullName);
        }
        #endregion

        #region main program loop
        public void IterateProjects(System.IO.DirectoryInfo root)
        {
            System.IO.DirectoryInfo[] subDirs = null;
            try
            {
                subDirs = root.GetDirectories();
            }
            catch (Exception e)
            {
                Model.Results.LogError(e.Message);
            }

            // this will iterate through each job folder
            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                string familyPath = dirInfo.FullName + @"\3_Process Families"; // TODO: set this name through the form
                System.IO.DirectoryInfo familyDir = new System.IO.DirectoryInfo(familyPath);

                if (familyDir.Exists)
                {
                    try
                    {
                        _search.WalkDirectoryTree(familyDir);
                    }
                    catch (Exception e)
                    {
                        Model.Results.LogError(e.Message);
                    }
                }
            }
        }
        #endregion

    }
}
