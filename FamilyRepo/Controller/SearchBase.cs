using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRepo.Controller
{
    abstract class SearchBase
    {
        protected FamilyRepo.Model.Results _res;
        protected Settings _set;

        public FamilyRepo.Model.Results Res
        {
            get { return _res; }
        }
        public Settings Set
        {
            get { return _set; }
        }
    }
}
