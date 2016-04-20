using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class COFINSAliq
    {
        private int _CST;
        private double _vBC;
        private double _pCOFINS;
        private double _vCOFINS;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double pCOFINS { get { return _pCOFINS; } set { _pCOFINS = value; } }
        public double vCOFINS { get { return _vCOFINS; } set { _vCOFINS = value; } }
    }
}
