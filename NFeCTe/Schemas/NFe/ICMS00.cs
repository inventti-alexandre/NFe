using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMS00
    {
        private int _orig;
        private int _CST;
        private int _modBC;
        private double _vBC;
        private double _plCMS;
        private double _vlCMS;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public int modBC { get { return _modBC; } set { _modBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _plCMS; } set { _plCMS = value; } }
        public double vlCMS { get { return _vlCMS; } set { _vlCMS = value; } }
    }
}
