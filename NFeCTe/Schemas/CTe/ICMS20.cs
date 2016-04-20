using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class ICMS20
    {
        private int _CST;
        private double _pRedBC;
        private double _vBC;
        private double _pICMS;
        private double _vICMS;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double pRedBC { get { return _pRedBC; } set { _pRedBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _pICMS; } set { _pICMS = value; } }
        public double vlCMS { get { return _vICMS; } set { _vICMS = value; } }
    }
}
