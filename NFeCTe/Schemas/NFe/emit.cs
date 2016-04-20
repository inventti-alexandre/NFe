using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class emit
    {
        public enderEmit enderEmit;

        private string _CNPJ;
        private string _CPF;
        private string _xNome;
        private string _xFant;
        private string _IE;
        private string _IM;

        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public string CPF { get { return _CPF; } set { _CPF = value; } }
        public string xNome { get { return _xNome; } set { _xNome = value; } }
        public string xFant { get { return _xFant; } set { _xFant = value; } }
        public string IE { get { return _IE; } set { _IE = value; } }
        public string IM { get { return _IM; } set { _IM = value; } }

        public emit()
        {
            enderEmit = new enderEmit();
        }
    }
}
