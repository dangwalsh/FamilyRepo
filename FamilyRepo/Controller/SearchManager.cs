using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Controller
{
    class SearchManager : IFileManage, INotifyPropertyChanged
    {
        #region Association with Search class
        private SearchBase _search;
        private Model.Stats _stats;
        private string _currentPath;

        public Model.Stats Stats
        {
            get { return _stats; }
        }
        public string CurrentPath
        {
            get { return _currentPath; }
            set
            {
                _currentPath = value;
                OnPropertyChanged("CurrentPath");
            }
        }

        public SearchManager()
        {
            _search = new SearchRecurse(this); // NOTE: change this type to instantiate a different search algorithm
            _stats = new Model.Stats();
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
                _stats.LogError(e.Message);
            }

            if (newfile != null)
            {
                _stats.UpMoved(file.FullName, newfile.FullName);
                DeleteFile(file);
            }
            else
            {
                _stats.LogError("Copy failed for unkown reasons.");
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
                _stats.LogError(e.Message);
            }
        }

        public void SkipFile(System.IO.FileInfo file)
        {
            _stats.UpSkipped(file.FullName);
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
                _stats.LogError(e.Message);
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
                        _stats.LogError(e.Message);
                    }
                }
            }

        }
        #endregion
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
