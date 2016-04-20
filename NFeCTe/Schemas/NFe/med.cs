using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class med
    {
        private string _nLote;
        private double _qLote;
        private string _dFab;
        private string _dVal;
        private double _vPMC;

        public string nLote { get { return _nLote; } set { _nLote = value; } }
        public double qLote { get { return _qLote; } set { _qLote = value; } }
        public string dFab { get { return _dFab; } set { _dFab = value; } }
        public string dVal { get { return _dVal; } set { _dVal = value; } }
        public double vPMC { get { return _vPMC; } set { _vPMC = value; } }
    }
}
