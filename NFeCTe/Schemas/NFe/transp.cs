using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contabil.Schema;

namespace Contabil
{
    public class transp
    {
        public transporta transporta;
        public retTransp retTransp;
        public vol vol;

        public veicTransp veicTransp;
        public reboque reboque;

        private int _modFrete;
        private string _vagao;
        private string _balsa;

        public int modFrete { get { return _modFrete; } set { _modFrete = value; } }
        public string vagao { get { return _vagao; } set { _vagao = value; } }
        public string balsa { get { return _balsa; } set { _balsa = value; } }
    }
}
