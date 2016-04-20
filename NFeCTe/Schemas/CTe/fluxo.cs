using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class fluxo
    {
        public pass pass;

        private string _xOrig;
        private string _xDest;
        private string _xRota;

        public string xOrig { get { return _xOrig; } set { _xOrig = value; } }
        public string xDest { get { return _xDest; } set { _xDest = value; } }
        public string xRota { get { return _xRota; } set { _xRota = value; } }
    }
}
