using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class vol
    {
        public lacres lacres;

        private double _vVol;
        private string _esp;
        private string _marca;
        private string _nVol;
        private double _pesoL;
        private double _pesoB;

        public double vVol { get { return _vVol; } set { _vVol = value; } }
        public string esp { get { return _esp; } set { _esp = value; } }
        public string marca { get { return _marca; } set { _marca = value; } }
        public string nVol { get { return _nVol; } set { _nVol = value; } }
        public double pesoL { get { return _pesoL; } set { _pesoL = value; } }
        public double pesoB { get { return _pesoB; } set { _pesoB = value; } }
    }
}
