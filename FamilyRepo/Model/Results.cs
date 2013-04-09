using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FamilyRepo.Interfaces;

namespace FamilyRepo.Model
{
    static class Results
    {
        private static int _moveCnt;
        private static int _skipCnt;
        private static int _errorCnt;
        private static List<MoveStat> _moved = new List<MoveStat>();
        private static List<SkipStat> _skipped = new List<SkipStat>();
        private static List<ErrorStat> _errors = new List<ErrorStat>();

        #region Public count properties for use by windows form labels
        public static int MoveCnt
        {
            get { return _moveCnt; }
        }
        public static int SkipCnt
        {
            get { return _skipCnt; }
        }
        public static int ErrorCnt
        {
            get { return _errorCnt; }
        }
        #endregion

        #region Public list properties for use by windows form datagridviews
        public static List<MoveStat> MovedFiles
        {
            get { return _moved; }
        }
        public static List<SkipStat> SkippedFiles
        {
            get { return _skipped; }
        }
        public static List<ErrorStat> Errors
        {
            get { return _errors; }
        }
        #endregion

        #region Public methods to be called by search class delegate
        public static void UpPath(string path)
        {
            throw new NotImplementedException();
        }

        public static void UpTime() /* TODO: determine if this should live in another class interface */
        {
            throw new NotImplementedException();
        }

        public static void UpMoved(string source, string target)
        {
            MoveStat ms = new MoveStat(source, target);
            _moved.Add(ms);
            _moveCnt = _moved.Count;
        }

        public static void UpSkipped(string source)
        {
            SkipStat ss = new SkipStat(source);
            _skipped.Add(ss);
            _skipCnt = _skipped.Count;
        }

        public static void LogError(string e)
        {
            ErrorStat es = new ErrorStat(e);
            _errors.Add(es);
            _errorCnt = _errors.Count;
        }
        #endregion
    }
}
