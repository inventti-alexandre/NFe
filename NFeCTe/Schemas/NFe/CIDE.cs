using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil.Schema
{
    public class CIDE
    {
        private int _qBCProd;
        private double _vAliqProd;
        private double _vCIDE;

        public int qBCProd { get { return _qBCProd; } set { _qBCProd = value; } }
        public double vAliqProd { get { return _vAliqProd; } set { _vAliqProd = value; } }
        public double vCIDE { get { return _vCIDE; } set { _vCIDE = value; } }
    }
}
