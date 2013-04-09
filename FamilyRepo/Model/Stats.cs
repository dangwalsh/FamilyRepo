using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Model
{
    class Stats
    {
        private int _moveCnt;
        private int _skipCnt;
        private int _errorCnt;
        private List<MoveStat> _moved = new List<MoveStat>();
        private List<SkipStat> _skipped = new List<SkipStat>();
        private List<ErrorStat> _errors = new List<ErrorStat>();

        #region Public count properties for use by windows form labels
        public int MoveCnt
        {
            get { return _moveCnt; }
        }
        public int SkipCnt
        {
            get { return _skipCnt; }
        }
        public int ErrorCnt
        {
            get { return _errorCnt; }
        }
        #endregion

        #region Public list properties for use by windows form datagridviews
        public List<MoveStat> MovedFiles
        {
            get { return _moved; }
        }
        public List<SkipStat> SkippedFiles
        {
            get { return _skipped; }
        }
        public List<ErrorStat> Errors
        {
            get { return _errors; }
        }
        #endregion

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
            _moveCnt = _moved.Count;
        }

        public void UpSkipped(string source)
        {
            SkipStat ss = new SkipStat(source);
            _skipped.Add(ss);
            _skipCnt = _skipped.Count;
        }

        public void LogError(string e)
        {
            ErrorStat es = new ErrorStat(e);
            _errors.Add(es);
            _errorCnt = _errors.Count;
        }
        #endregion
    }
}
