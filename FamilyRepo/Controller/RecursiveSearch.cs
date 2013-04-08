using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Controller
{
    class RecursiveSearch : RootSearch, IWalk
    {
        public RecursiveSearch(Settings s) : base(s)
        {
        }

        // the entry point of this recursion should be no higher than the folder holding families
        public void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // first process all of the files directly in this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                this.Res.LogError(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                this.Res.LogError(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    MoveFile(fi);
                }

                // now get all of the subdirectories under this directory
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // recursive call to self
                    WalkDirectoryTree(dirInfo);
                }
            }
        }

        // the entry point of this recursion should be the root of the projects directory
        public void IterateProjects(System.IO.DirectoryInfo root)
        {
            System.IO.DirectoryInfo[] subDirs = null;
            try
            {
                subDirs = root.GetDirectories();
            }
            catch (Exception e)
            {
                this.Res.LogError(e.Message);
            }

            // this will iterate through each job folder
            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                string familyPath = dirInfo.FullName + @"\Process_Families"; // TODO: set this name through the form
                System.IO.DirectoryInfo familyDir = new System.IO.DirectoryInfo(familyPath);

                if (familyDir.Exists)
                {
                    try
                    {
                        WalkDirectoryTree(familyDir);
                    }
                    catch (Exception e)
                    {
                        this.Res.LogError(e.Message);
                    }
                }
            }
        }
    }
}
