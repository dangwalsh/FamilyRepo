using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Model
{
    class Stats : INotifyPropertyChanged
    {
        private int _moveCnt;
        private int _skipCnt;
        private int _errorCnt;
        private BindingList<MoveStat> _moved;
        private BindingList<SkipStat> _skipped;
        private BindingList<ErrorStat> _errors;

        #region Public count properties for use by windows form labels
        public int MoveCnt
        {
            get { return _moveCnt; }
            set
            {
                _moveCnt = value;
                OnPropertyChanged("MoveCnt");
            }
        }
        public int SkipCnt
        {
            get { return _skipCnt; }
            set
            {
                _skipCnt = value;
                OnPropertyChanged("SkipCnt");
            }
        }
        public int ErrorCnt
        {
            get { return _errorCnt; }
            set
            {
                _errorCnt = value;
                OnPropertyChanged("ErrorCnt");
            }
        }
        #endregion

        #region Public list properties for use by windows form datagridviews
        public BindingList<MoveStat> MovedFiles
        {
            get { return _moved; }
        }
        public BindingList<SkipStat> SkippedFiles
        {
            get { return _skipped; }
        }
        public BindingList<ErrorStat> Errors
        {
            get { return _errors; }
        }
        #endregion

        public Stats()
        {
            _moved = new BindingList<MoveStat>();
            _skipped = new BindingList<SkipStat>();
            _errors = new BindingList<ErrorStat>();
        }

        #region Public methods to be called by search class delegate
        public void UpPath(string path)
        {
            throw new NotImplementedException();
        }

        public void UpTime() /* TODO: determine if this should live in another class interface */
        {
            throw new NotImplementedException();
        }

        public void UpMoved(string source, string target)
        {
            MoveStat ms = new MoveStat(source, target);
            _moved.Add(ms);
            this.MoveCnt = _moved.Count;
        }

        public void UpSkipped(string source)
        {
            SkipStat ss = new SkipStat(source);
            _skipped.Add(ss);
            this.SkipCnt = _skipped.Count;
        }

        public void LogError(string e)
        {
            ErrorStat es = new ErrorStat(e);
            _errors.Add(es);
            this.ErrorCnt = _errors.Count;
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
