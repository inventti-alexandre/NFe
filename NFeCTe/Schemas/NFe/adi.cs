using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class adi
    {
        private int _nAdicao;
        private int _nSeqAdic;
        private string _cFabricante;
        private double _vDescDI;
        private string _nDraw;

        public int nAdicao { get { return _nAdicao; } set { _nAdicao = value; } }
        public int nSeqAdic { get { return _nSeqAdic; } set { _nSeqAdic = value; } }
        public string cFabricante { get { return _cFabricante; } set { _cFabricante = value; } }
        public double vDescDI { get { return _vDescDI; } set { _vDescDI = value; } }
        public string nDraw { get { return _nDraw; } set { _nDraw = value; } }
    }
}
