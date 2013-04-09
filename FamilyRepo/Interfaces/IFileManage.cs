using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Interfaces
{
    interface IFileManage
    {
        void MoveFile(System.IO.FileInfo file);
        void DeleteFile(System.IO.FileInfo file);
        void SkipFile(System.IO.FileInfo file);
    }
}
