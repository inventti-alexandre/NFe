using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMS40
    {
        private int _orig;
        private int _CST;
        private double _vICMSDeson;
        private int _motDesICMS;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public double vICMSDeson { get { return _vICMSDeson; } set { _vICMSDeson = value; } }
        public int motDesICMS { get { return _motDesICMS; } set { _motDesICMS = value; } }
    }
}
