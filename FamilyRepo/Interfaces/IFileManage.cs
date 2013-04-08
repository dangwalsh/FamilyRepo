using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Interfaces
{
    interface IFileManage
    {
        public void MoveFile(System.IO.FileInfo file);
        public void DeleteFile(System.IO.FileInfo file);
        public void SkipFile(System.IO.FileInfo file);
    }
}
