using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class COFINSQtde
    {
        private int _CST;
        private double _qBCProd;
        private double _vAliqProd;
        private double _vCOFINS;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double qBCProd { get { return _qBCProd; } set { _qBCProd = value; } }
        public double vAliqProd { get { return _vAliqProd; } set { _vAliqProd = value; } }
        public double vCOFINS { get { return _vCOFINS; } set { _vCOFINS = value; } }
    }
}
