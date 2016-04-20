using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class exportInd
    {
        private string _nRE;
        private string _chNFe;
        private double _qExport;

        public string nRE { get { return _nRE; } set { _nRE = value; } }
        public string chNFe { get { return _chNFe; } set { _chNFe = value; } }
        public double qExport { get { return _qExport; } set { _qExport = value; } }
    }
}
