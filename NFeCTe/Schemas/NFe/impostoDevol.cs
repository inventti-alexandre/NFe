using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil.Schema
{
    public class impostoDevol
    {
        public IPI IPI;

        private double _pDevol;

        public double pDevol { get { return _pDevol; } set { _pDevol = value; } }
    }
}
