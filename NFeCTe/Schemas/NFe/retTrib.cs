using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class retTrib
    {
        private double _vRetPIS;
        private double _vRetCOFINS;
        private double _vRetCSLL;
        private double _vBCIRRF;
        private double _vIRRF;
        private double _vBCRetPrev;
        private double _vRetPrev;

        public double vRetPIS { get { return _vRetPIS; } set { _vRetPIS = value; } }
        public double vRetCOFINS { get { return _vRetCOFINS; } set { _vRetCOFINS = value; } }
        public double vRetCSLL { get { return _vRetCSLL; } set { _vRetCSLL = value; } }
        public double vBCIRRF { get { return _vBCIRRF; } set { _vBCIRRF = value; } }
        public double vIRRF { get { return _vIRRF; } set { _vIRRF = value; } }
        public double vBCRetPrev { get { return _vBCRetPrev; } set { _vBCRetPrev = value; } }
        public double vRetPrev { get { return _vRetPrev; } set { _vRetPrev = value; } }
    }
}
