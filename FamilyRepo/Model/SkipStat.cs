﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Model
{
    class SkipStat
    {
        private static int _count;
        private int _number;
        private string _source;

        public int Number
        {
            get { return _number; }
        }
        public string Source
        {
            get { return _source; }
        }

        public SkipStat(string s)
        {
            ++_count;
            _number = _count;
            _source = s;
        }
    }
}
