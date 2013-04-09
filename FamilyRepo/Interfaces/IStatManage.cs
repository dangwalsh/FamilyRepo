using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Interfaces
{
    interface IStatManage
    {
        void UpPath(string path);
        void UpTime();
        void UpMoved(string source, string target);
        void UpSkipped(string source);
        void LogError(string e);
    }
}
