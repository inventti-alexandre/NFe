using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class ICMS00
    {
        private int _CST;
        private double _vBC;
        private double _plCMS;
        private double _vlCMS;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _plCMS; } set { _plCMS = value; } }
        public double vlCMS { get { return _vlCMS; } set { _vlCMS = value; } }
    }
}
