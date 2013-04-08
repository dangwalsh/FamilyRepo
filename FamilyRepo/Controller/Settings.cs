using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Controller
{
    class Settings
    {
        private string _rootPath;
        private string _targetPath;
        private string _sourcePath;
        private double _maxSearchTm;
        private double _maxCopyTm;

        public string RootPath
        {
            get { return _rootPath; }
            set { _rootPath = value; }
        }
        public string TargetPath
        {
            get { return _targetPath; }
            set { _targetPath = value; }
        }
        public string SourcePath
        {
            get { return _sourcePath; }
            set { _sourcePath = value; }
        }
        public double MaxSearchTm
        {
            get { return _maxSearchTm; }
            set { _maxSearchTm = value; }
        }
        public double MaxCopyTm
        {
            get { return _maxCopyTm; }
            set { _maxCopyTm = value; }
        }
    }
}
