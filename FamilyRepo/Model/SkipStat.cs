﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Model
{
    class SkipStat
    {
        private string _source;

        public string Source
        {
            get { return _source; }
        }

        public SkipStat(string s)
        {
            _source = s;
        }
    }
}
