using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Model
{
    class Results : IStatManage
    {
        private int _moveCnt;
        private int _skipCnt;
        private int _errorCnt;

        private List<MoveStat> _moved = new List<MoveStat>();
        private List<SkipStat> _skipped = new List<SkipStat>();
        private List<string> _errors = new List<string>();

        // expose count fields for use by form label
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

        // expose list fields for use by form datagridview
        public List<MoveStat> Moved
        {
            get { return _moved; }
        }
        public List<SkipStat> Skipped
        {
            get { return _skipped; }
        }
        public List<string> Errors
        {
            get { return _errors; }
        }

        // methods to be called by search class
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
            _errors.Add(e);
            _errorCnt = _errors.Count;
        }
    }
}
