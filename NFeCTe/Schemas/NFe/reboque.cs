using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil.Schema
{
    public class reboque
    {
        private string _placa;
        private string _UF;
        private string _RNTC;
        private string _vagao;
        private string _balsa;

        public string placa { get { return _placa; } set { _placa = value; } }
        public string UF { get { return _UF; } set { _UF = value; } }
        public string RNTC { get { return _RNTC; } set { _RNTC = value; } }
        public string vagao { get { return _vagao; } set { _vagao = value; } }
        public string balsa { get { return _balsa; } set { _balsa = value; } }
    }
}
