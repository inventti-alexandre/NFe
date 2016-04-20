using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class refNF
    {
        private int _cUF;
        private string _AAMM;
        private string _CNPJ;
        private int _mod;
        private int _serie;
        private string _nNF;

        public int cUF { get { return _cUF; } set { _cUF = value; } }
        public string AAMM { get { return _AAMM; } set { _AAMM = value; } }
        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public int mod { get { return _mod; } set { _mod = value; } }
        public int serie { get { return _serie; } set { _serie = value; } }
        public string nNF { get { return _nNF; } set { _nNF = value; } }
    }
}
