using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class ISSQNTot
    {
        private double _vServ;
        private double _vBC;
        private double _vISS;
        private double _vPIS;
        private double _vCOFINS;
        private string _dCompet;
        private double _vDeducao;
        private double _vOutro;
        private double _vDescIncond;
        private double _vDescCond;
        private double _vISSRet;
        private int _cRegTrib;

        public double vServ { get { return _vServ; } set { _vServ = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double vISS { get { return _vISS; } set { _vISS = value; } }
        public double vPIS { get { return _vPIS; } set { _vPIS = value; } }
        public double vCOFINS { get { return _vCOFINS; } set { _vCOFINS = value; } }
        public string dCompet { get { return _dCompet; } set { _dCompet = value; } }
        public double vDeducao { get { return _vDeducao; } set { _vDeducao = value; } }
        public double vOutro { get { return _vOutro; } set { _vOutro = value; } }
        public double vDescIncond { get { return _vDescIncond; } set { _vDescIncond = value; } }
        public double vDescCond { get { return _vDescCond; } set { _vDescCond = value; } }
        public double vISSRet { get { return _vISSRet; } set { _vISSRet = value; } }
        public int cRegTrib { get { return _cRegTrib; } set { _cRegTrib = value; } }
    }
}
