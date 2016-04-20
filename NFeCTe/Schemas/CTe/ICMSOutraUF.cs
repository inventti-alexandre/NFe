using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class ICMSOutraUF
    {
        private int _CST;
        private double _pRedBCOutraUF;
        private double _vBCOutraUF;
        private double _pICMSOutraUF;
        private double _vICMSOutraUF;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double pRedBCOutraUF { get { return _pRedBCOutraUF; } set { _pRedBCOutraUF = value; } }
        public double vBCOutraUF { get { return _vBCOutraUF; } set { _vBCOutraUF = value; } }
        public double pICMSOutraUF { get { return _pICMSOutraUF; } set { _pICMSOutraUF = value; } }
        public double vICMSOutraUF { get { return _vICMSOutraUF; } set { _vICMSOutraUF = value; } }
    }
}
