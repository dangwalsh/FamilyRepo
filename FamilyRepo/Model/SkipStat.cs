using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Model
{
    class SkipStat
    {
        private string _src;

        public string Src
        {
            get { return _src; }
        }

        public SkipStat(string s)
        {
            _src = s;
        }
    }
}
