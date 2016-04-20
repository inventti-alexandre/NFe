using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSSN900
    {
        private int _orig;
        private int _CSOSN;
        private int _modBC;
        private double _vBC;
        private double _pRedBC;
        private double _pICMS;
        private double _vICMS;
        private int _modBCST;
        private double _PMVAST;
        private double _pRedBCST;
        private double _vBCST;
        private double _pICMSST;
        private double _vICMSST;
        private double _pCredSN;
        private double _vCredICMSSN;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CSOSN { get { return _CSOSN; } set { _CSOSN = value; } }
        public int modBC { get { return _modBC; } set { _modBC = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double pRedBC { get { return _pRedBC; } set { _pRedBC = value; } }
        public double pICMS { get { return _pICMS; } set { _pICMS = value; } }
        public double vICMS { get { return _vICMS; } set { _vICMS = value; } }
        public int modBCST { get { return _modBCST; } set { _modBCST = value; } }
        public double PMVAST { get { return _PMVAST; } set { _PMVAST = value; } }
        public double pRedBCST { get { return _pRedBCST; } set { _pRedBCST = value; } }
        public double vBCST { get { return _vBCST; } set { _vBCST = value; } }
        public double pICMSST { get { return _pICMSST; } set { _pICMSST = value; } }
        public double vICMSST { get { return _vICMSST; } set { _vICMSST = value; } }
        public double pCredSN { get { return _pCredSN; } set { _pCredSN = value; } }
        public double vCredICMSSN { get { return _vCredICMSSN; } set { _vCredICMSSN = value; } }
    }
}
