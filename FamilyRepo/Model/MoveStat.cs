using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Model
{
    class MoveStat
    {
        private string _src;
        private string _tgt;

        public string Src
        {
            get { return _src; }
        }

        public string Tgt
        {
            get { return _tgt; }
        }

        public MoveStat(string s, string t)
        {
            _src = s;
            _tgt = t;
        }
    }
}
