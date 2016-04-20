using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class imposto
    {
        public ICMS ICMS;
        public IPI IPI;
        public II II;
        public ISSQN ISSQN;

        public PIS PIS;
        public PISST PISST;
        public COFINS COFINS;
        public COFINSST COFINSST;

        private double _vTotTrib;

        public double vTotTrib { get { return _vTotTrib; } set { _vTotTrib = value; } }
    }
}
