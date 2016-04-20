using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class transporta
    {
        private string _CNPJ;
        private string _CPF;
        private string _xNome;
        private string _IE;
        private string _xEnder;
        private string _xMun;
        private string _UF;

        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public string CPF { get { return _CPF; } set { _CPF = value; } }
        public string xNome { get { return _xNome; } set { _xNome = value; } }
        public string IE { get { return _IE; } set { _IE = value; } }
        public string xEnder { get { return _xEnder; } set { _xEnder = value; } }
        public string xMun { get { return _xMun; } set { _xMun = value; } }
        public string UF { get { return _UF; } set { _UF = value; } }
    }
}
