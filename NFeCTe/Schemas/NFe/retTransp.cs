using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class retTransp
    {
        private double _vServ;
        private double _vBCRet;
        private double _pICMSRet;
        private double _vICMSRet;
        private double _CFOP;
        private int _cMunFG;

        public double vServ { get { return _vServ; } set { _vServ = value; } }
        public double vBCRet { get { return _vBCRet; } set { _vBCRet = value; } }
        public double pICMSRet { get { return _pICMSRet; } set { _pICMSRet = value; } }
        public double vICMSRet { get { return _vICMSRet; } set { _vICMSRet = value; } }
        public double CFOP { get { return _CFOP; } set { _CFOP = value; } }
        public int cMUNFG { get { return _cMunFG; } set { _cMunFG = value; } }
    }
}
