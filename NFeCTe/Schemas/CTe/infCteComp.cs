using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class infCteComp
    {
        public vPresComp vPresComp;
        public impComp impComp;

        private string _chave;

        public string chave { get { return _chave; } set { _chave = value; } }
    }
}
