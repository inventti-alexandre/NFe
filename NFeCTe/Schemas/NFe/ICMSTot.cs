using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSTot
    {
        private double _vBC;
        private double _vICMS;
        private double _vICMSDeson;
        private double _vBCST;
        private double _vST;
        private double _vProd;
        private double _vFrete;
        private double _vSeg;
        private double _vDesc;
        private double _vII;
        private double _vPIS;
        private double _vCOFINS;
        private double _vOutro;
        private double _vNF;
        private double _vTotTrib;

        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double vICMS { get { return _vICMS; } set { _vICMS = value; } }
        public double vICMDeson { get { return _vICMSDeson; } set { _vICMSDeson = value; } }
        public double vBCST { get { return _vBCST; } set { _vBCST = value; } }
        public double vST { get { return _vST; } set { _vST = value; } }
        public double vProd { get { return _vProd; } set { _vProd = value; } }
        public double vFrete { get { return _vFrete; } set { _vFrete = value; } }
        public double vSeg { get { return _vSeg; } set { _vSeg = value; } }
        public double vDesc { get { return _vDesc; } set { _vDesc = value; } }
        public double vII { get { return _vII; } set { _vII = value; } }
        public double vPIS { get { return _vPIS; } set { _vPIS = value; } }
        public double vCOFINS { get { return _vCOFINS; } set { _vCOFINS = value; } }
        public double vOutro { get { return _vOutro; } set { _vOutro = value; } }
        public double vNF { get { return _vNF; } set { _vNF = value; } }
        public double vTotTrib { get { return _vTotTrib; } set { _vTotTrib = value; } }
    }
}
