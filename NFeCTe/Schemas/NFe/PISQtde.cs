using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class PISQtde
    {
        private int _CST;
        private double _qBCProd;
        private double _vAliqProd;
        private double _vPIS;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double qBCProd { get { return _qBCProd; } set { _qBCProd = value; } }
        public double vAliqProd { get { return _vAliqProd; } set { _vAliqProd = value; } }        
        public double vPIS { get { return _vPIS; } set { _vPIS = value; } }
    }
}
