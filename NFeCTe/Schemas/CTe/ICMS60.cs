using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class ICMS60
    {
        private int _CST;
        private double _vBCSTRet;
        private double _vICMSSTRet;
        private double _pICMSSTRet;
        private double _vCred;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double vBCSTRet { get { return _vBCSTRet; } set { _vBCSTRet = value; } }
        public double vICMSSTRet { get { return _vICMSSTRet; } set { _vICMSSTRet = value; } }
        public double pICMSSTRet { get { return _pICMSSTRet; } set { _pICMSSTRet = value; } }
        public double vCred { get { return _vCred; } set { _vCred = value; } }
    }
}
