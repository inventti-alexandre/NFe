using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ICMSSN202
    {
        private int _orig;
        private int _CSOSN;
        private int _modBCST;
        private double _PMVAST;
        private double _pRedBCST;
        private double _vBCST;
        private double _pICMSST;
        private double _vICMSST;

        public int orig { get { return _orig; } set { _orig = value; } }
        public int CSOSN { get { return _CSOSN; } set { _CSOSN = value; } }
        public int modBCST { get { return _modBCST; } set { _modBCST = value; } }
        public double PMVAST { get { return _PMVAST; } set { _PMVAST = value; } }
        public double pRedBCST { get { return _pRedBCST; } set { _pRedBCST = value; } }
        public double vBCST { get { return _vBCST; } set { _vBCST = value; } }
        public double pICMSST { get { return _pICMSST; } set { _pICMSST = value; } }
        public double vICMSST { get { return _vICMSST; } set { _vICMSST = value; } }
    }
}
