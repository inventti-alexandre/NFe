using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMS30
    {
        private int _orig;
        private int _CST;
        private int _modBCST;
        private double _pMVAST;
        private double _pRedBCST;
        private double _vBCST;
        private double _pICMSST;
        private double _vICMSST;
        private double _vICMSDeson;
        private int _motDesICMS;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public int modBCST { get { return _modBCST; } set { _modBCST = value; } }
        public double pMVAST { get { return _pMVAST; } set { _pMVAST = value; } }
        public double pRedBCST { get { return _pRedBCST; } set { _pRedBCST = value; } }
        public double vBCST { get { return _vBCST; } set { _vBCST = value; } }
        public double plCMSST { get { return _pICMSST; } set { _pICMSST = value; } }
        public double vlCMSST { get { return _vICMSST; } set { _vICMSST = value; } }
        public double vICMSDeson { get { return _vICMSDeson; } set { _vICMSDeson = value; } }
        public int motDescICMS { get { return _motDesICMS; } set { _motDesICMS = value; } }
    }
}
