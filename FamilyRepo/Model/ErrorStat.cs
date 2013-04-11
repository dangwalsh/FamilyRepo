using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Model
{
    class ErrorStat
    {
        private static int _count;
        private int _number;
        private string _error;

        public int Number
        {
            get { return _number; }
        }
        public string Error
        {
            get { return _error; }
        }

        public ErrorStat(string e)
        {
            ++_count;
            _number = _count; 
            _error = e;
        }
    }
}
