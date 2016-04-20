using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public  class ISSQN
    {
        private double _vBC;
        private double _vAliq;
        private double _vISSQN;
        private int _cMumFG;
        private string _cListServ;
        private double _vDeducao;
        private double _vOutro;
        private double _vDescIncond;
        private double _vDescCond;
        private double _vISSRet;
        private int _intISS;
        private string _cServico;
        private int _cMun;
        private int _cPais;
        private string _nProcesso;
        private int _indIncentivo;

        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double vAliq { get { return _vAliq; } set { _vAliq = value; } }
        public double vISSQN { get { return _vISSQN; } set { _vISSQN = value; } }
        public int cMunFG { get { return _cMumFG; } set { _cMumFG = value; } }
        public string cListServ { get { return _cListServ; } set { _cListServ = value; } }
        public double vDeducao { get { return _vDeducao; } set { _vDeducao = value; } }
        public double vOutro { get { return _vOutro; } set { _vOutro = value; } }
        public double vDescIncond { get { return _vDescIncond; } set { _vDescIncond = value; } }
        public double vDescCond { get { return _vDescCond; } set { _vDescCond = value; } }
        public double vISSRet { get { return _vISSRet; } set { _vISSRet = value; } }
        public int intISS { get { return _intISS; } set { _intISS = value; } }
        public string cServico { get { return _cServico; } set { _cServico = value; } }
        public int cMun { get { return _cMun; } set { _cMun = value; } }
        public int cPais { get { return _cPais; } set { _cPais = value; } }
        public string nProcesso { get { return _nProcesso; } set { _nProcesso = value; } }
        public int indIncentivo { get { return _indIncentivo; } set { _indIncentivo = value; } }
    }
}
