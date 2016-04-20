using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSSN500
    {
        private int _orig;
        private int _CSOSN;
        private double _vBCSTRet;
        private double _vICMSSTRet;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CSOSN { get { return _CSOSN; } set { _CSOSN = value; } }
        public double vBCSTRet { get { return _vBCSTRet; } set { _vBCSTRet = value; } }
        public double vICMSSTRet { get { return _vICMSSTRet; } set { _vICMSSTRet = value; } }
    }
}
