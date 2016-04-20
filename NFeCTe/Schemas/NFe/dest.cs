using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class dest
    {
        public enderDest enderDest;

        private string _CNPJ;
        private string _CPF;
        private string _idEstrangeiro;
        private string _xNome;
        private string _IE;
        private string _IM;
        private string _ISUF;

        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public string CPF { get { return _CPF; } set { _CPF = value; } }
        public string idEstrangeiro { get { return _idEstrangeiro; } set { _idEstrangeiro = value; } }
        public string xNome { get { return _xNome; } set { _xNome = value; } }
        public string IE { get { return _IE; } set { _IE = value; } }
        public string IM { get { return _IM; } set { _IM = value; } }
        public string ISUF { get { return _ISUF; } set { _ISUF = value; } } 
    }
}
