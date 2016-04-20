using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class seg
    {
        private int _respSeg;
        private string _xSeg;
        private string _nApol;
        private string _nAver;
        private double _vCarga;

        public int respSeg { get { return _respSeg; } set { _respSeg = value; } }
        public string xSeg { get { return _xSeg; } set { _xSeg = value; } }
        public string nApol { get { return _nApol; } set { _nApol = value; } }
        public string nAver { get { return _nAver; } set { _nAver = value; } }
        public double vCarga { get { return _vCarga; } set { _vCarga = value; } }
    }
}
