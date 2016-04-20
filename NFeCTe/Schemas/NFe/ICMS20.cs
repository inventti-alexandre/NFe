using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMS20
    {
        private int _orig;
        private int _CST;
        private int _modBC;
        private double _pRedBC;
        private double _vBC;
        private double _pICMS;
        private double _vICMS;
        private double _vICMSDeson;
        private int _motDesICMS;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public int modBC { get { return _modBC; } set { _modBC = value; } }
        public double pRedBC { get { return _pRedBC; } set { _pRedBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _pICMS; } set { _pICMS = value; } }
        public double vlCMS { get { return _vICMS; } set { _vICMS = value; } }
        public double vICMSDeson { get { return _vICMSDeson; } set { _vICMSDeson = value; } }
        public int motDescICMS { get { return _motDesICMS; } set { _motDesICMS = value; } }
    }
}
