using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class ICMS90
    {
        private int _CST;
        private double _pRedBC;
        private double _vBC;
        private double _pICMS;
        private double _vICMS;
        private double _vCred;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double pRedBC { get { return _pRedBC; } set { _pRedBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _pICMS; } set { _pICMS = value; } }
        public double vlCMS { get { return _vICMS; } set { _vICMS = value; } }
        public double vCred { get { return _vCred; } set { _vCred = value; } }
    }
}
