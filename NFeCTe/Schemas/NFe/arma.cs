using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class arma
    {
        private int _tpArma;
        private string _nSerie;
        private string _nCano;
        private string _descr;

        public int tpArma { get { return _tpArma; } set { _tpArma = value; } }
        public string nSerie { get { return _nSerie; } set { _nSerie = value; } }
        public string nCano { get { return _nCano; } set { _nCano = value; } }
        public string descr { get { return _descr; } set { _descr = value; } }
    }
}
