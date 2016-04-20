using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contabil.Schema;

namespace Contabil
{
    public class comb
    {
        public CIDE CIDE;

        private string _cProdANP;
        private double _pMixGN;
        private string _CODIF;
        private double _qTemp;
        private string _UFCons;

        public string cProdANP { get { return _cProdANP; } set { _cProdANP = value; } }
        public double pMixGN { get { return _pMixGN; } set { _pMixGN = value; } }
        public string CODIF { get { return _CODIF; } set { _CODIF = value; } }
        public double qTemp { get { return _qTemp; } set { _qTemp = value; } }
        public string UFCons { get { return _UFCons; } set { _UFCons = value; } }
    }
}
