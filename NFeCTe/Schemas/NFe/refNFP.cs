using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class refNFP
    {
        private int _cUF;
        private string _AAMM;
        private string _CNPJ;
        private string _CPF;
        private string _IE;
        private int _mod;
        private int _serie;
        private string _nNF;
        private string _refCTe;

        public int cUF { get { return _cUF; } set { _cUF = value; } }
        public string AAMM { get { return _AAMM; } set { _AAMM = value; } }
        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public string CPF { get { return _CPF; } set { _CPF = value; } }
        public string IE { get { return _IE; } set { _IE = value; } }
        public int mod { get { return _mod; } set { _mod = value; } }
        public int serie { get { return _serie; } set { _serie = value; } }
        public string nNF { get { return _nNF; } set { _nNF = value; } }
        public string refCTe { get { return _refCTe; } set { _refCTe = value; } }
    }
}
