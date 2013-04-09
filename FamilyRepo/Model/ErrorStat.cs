using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Model
{
    class ErrorStat
    {
        private string _error;

        public string Error
        {
            get { return _error; }
        }

        public ErrorStat(string e)
        {
            _error = e;
        }
    }
}
