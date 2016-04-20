using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class pag
    {
        public card card;

        private int _tPag;
        private double _vPag;

        public int tPag { get { return _tPag; } set { _tPag = value; } }
        public double vPag { get { return _vPag; } set { _vPag = value; } }
    }
}
