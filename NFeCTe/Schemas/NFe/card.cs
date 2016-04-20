using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class card
    {
        private string _CNPJ;
        private int _tBand;
        private string _cAut;

        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public int tBand { get { return _tBand; } set { _tBand = value; } }
        public string cAut { get { return _cAut; } set { _cAut = value; } }
    }
}
