using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSPart
    {
        private int _orig;
        private int _CST;
        private int _modBC;
        private double _pRedBC;
        private double _vBC;
        private double _pICMS;
        private double _vICMS;
        private int _modBCST;
        private double _pMVAST;
        private double _pRedBCST;
        private double _vBCST;
        private double _pICMSST;
        private double _vICMSST;
        private double _pBCOp;
        private string _UFST;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public int modBC { get { return _modBC; } set { _modBC = value; } }
        public double pRedBC { get { return _pRedBC; } set { _pRedBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _pICMS; } set { _pICMS = value; } }
        public double vlCMS { get { return _vICMS; } set { _vICMS = value; } }
        public int modBCST { get { return _modBCST; } set { _modBCST = value; } }
        public double pMVAST { get { return _pMVAST; } set { _pMVAST = value; } }
        public double pRedBCST { get { return _pRedBCST; } set { _pRedBCST = value; } }
        public double vBCST { get { return _vBCST; } set { _vBCST = value; } }
        public double pICMSST { get { return _pICMSST; } set { _pICMSST = value; } }
        public double vICMSST { get { return _vICMSST; } set { _vICMSST = value; } }
        public double pBCOp { get { return _pBCOp; } set { _pBCOp = value; } }
        public string UFST { get { return _UFST; } set { _UFST = value; } }
    }
}
