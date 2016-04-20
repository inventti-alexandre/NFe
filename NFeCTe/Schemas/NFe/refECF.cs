using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class refECF
    {
        private string _mod;
        private int _nECF;
        private int _nCOO;

        public string mod { get { return _mod; } set { _mod = value; } }
        public int nECF { get { return _nECF; } set { _nECF = value; } }
        public int nCOO { get { return _nCOO; } set { _nCOO = value; } }
    }
}
