using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSSN102
    {
        private int _orig;
        private int _CSOSN;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CSOSN { get { return _CSOSN; } set { _CSOSN = value; } }
    }
}
