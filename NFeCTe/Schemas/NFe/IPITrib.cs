using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class IPITrib
    {
        private int _CST;
        private double _vBC;
        private double _pIPI;
        private double _qUnid;
        private double _vUnid;
        private double _vIPI;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double pIPI { get { return _pIPI; } set { _pIPI = value; } }
        public double qUnid { get { return _qUnid; } set { _qUnid = value; } }
        public double vUnid { get { return _vUnid; } set { _vUnid = value; } }
        public double vIPI { get { return _vIPI; } set { _vIPI = value; } }
    }
}
