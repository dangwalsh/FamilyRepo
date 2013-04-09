using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Model
{
    class MoveStat
    {
        private string _source;
        private string _target;

        public string Source
        {
            get { return _source; }
        }

        public string Target
        {
            get { return _target; }
        }

        public MoveStat(string s, string t)
        {
            _source = s;
            _target = t;
        }
    }
}
