using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSST
    {
        private int _orig;
        private int _CST;
        private double _vBSSTRet;
        private double _vICMSSTRet;
        private double _vBCSTDest;
        private double _vICMSSTDest;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public double vBSSTRet { get { return _vBSSTRet; } set { _vBSSTRet = value; } }
        public double vICMSSTRet { get { return _vICMSSTRet; } set { _vICMSSTRet = value; } }
        public double vBCSTDest { get { return _vBCSTDest; } set { _vBCSTDest = value; } }
        public double vICMSSTDest { get { return _vICMSSTDest; } set { _vICMSSTDest = value; } }
    }
}
