using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMS10
    {
        private int _orig;
        private int _CST;
        private int _modBC;
        private double _vBC;
        private double _plCMS;
        private double _vlCMS;
        private int _modBCST;
        private double _pMVAST;
        private double _pRedBCST;
        private double _vBCST;
        private double _plCMSST;
        private double _vlCMSST;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CST { get { return _CST; } set { _CST = value; } }
        public int modBC { get { return _modBC; } set { _modBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double plCMS { get { return _plCMS; } set { _plCMS = value; } }
        public double vlCMS { get { return _vlCMS; } set { _vlCMS = value; } }
        public int modBCST { get { return _modBCST; } set { _modBCST = value; } }
        public double pMVAST { get { return _pMVAST; } set { _pMVAST = value; } }
        public double pRedBCST { get { return _pRedBCST; } set { _pRedBCST = value; } }
        public double vBCST { get { return _vBCST; } set { _vBCST = value; } }
        public double plCMSST { get { return _plCMSST; } set { _plCMSST = value; } }
        public double vlCMSST { get { return _vlCMSST; } set { _vlCMSST = value; } }
    }
}
