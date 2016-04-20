using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class autXML
    {
        private string _CNPJ;
        private string _CPF;

        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public string CPF { get { return _CPF; } set { _CPF = value; } }
    }
}
