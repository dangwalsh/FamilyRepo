using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Interfaces
{
    interface IStatManage
    {
        public void UpPath(string path);
        public void UpTime();
        public void UpMoved(string source, string target);
        public void UpSkipped(string source);
        public void LogError(string e);
    }
}
