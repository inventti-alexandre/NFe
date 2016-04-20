using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSSN101
    {
        private int _orig;
        private int _CSOSN;
        private double _pCredSN;
        private double _vCredICMSSN;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CSOSN { get { return _CSOSN; } set { _CSOSN = value; } }
        public double pCredSN { get { return _pCredSN; } set { _pCredSN = value; } }
        public double vCredICMSSN { get { return _vCredICMSSN; } set { _vCredICMSSN = value; } }
    }
}
