using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Interfaces
{
    interface IWalk
    {
        public void WalkDirectoryTree(System.IO.DirectoryInfo root);
        public void IterateProjects(System.IO.DirectoryInfo root);
    }
}
