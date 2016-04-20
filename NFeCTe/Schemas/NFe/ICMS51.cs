using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMS51
    {
        private int _orig;
        private int _CST;
        private int _modBC;
        private double _pRedBC;
        private double _vBC;
        private double _pICMS;
        private double _vICMSOp;
        private double _pDif;
        private double _vICMSDif;
        private double _vICMSDeson;
        private int _motDesICMS;
        private double _vICMS;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public int modBC { get { return _modBC; } set { _modBC = value; } }
        public double pRedBC { get { return _pRedBC; } set { _pRedBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _pICMS; } set { _pICMS = value; } }
        public double vlCMSOp { get { return _vICMSOp; } set { _vICMSOp = value; } }
        public double pDif { get { return _pDif; } set { _pDif = value; } }
        public double vICMSDif { get { return _pDif; } set { _pDif = value; } }
        public double vICMSDeson { get { return _vICMSDif; } set { _vICMSDif = value; } }
        public int motDescICMS { get { return _motDesICMS; } set { _motDesICMS = value; } }
        public double vICMS { get { return _vICMS; } set { _vICMS = value; } }
    }
}
