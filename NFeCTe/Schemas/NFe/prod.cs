using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class prod
    {
        public DI DI;
        public detExport detExport;
        public veicProd veicProd;
        public med med;
        public arma arma;
        public comb comb;

        private string _xPed;
        private int _nItemPed;
        private string _nFCI;

        private string _cProd;
        private string _cEAN;
        private string _xProd;
        private double _NCM;
        private string _NVE;
        private double _EXTIPI;
        private double _CFOP;
        private string _uCom;
        private double _qCom;
        private double _vUnCom;
        private double _vProd;
        private string _cEANTrib;
        private string _uTrib;
        private double _qTrib;
        private double _vUnTrib;
        private double _vFrete;
        private double _vSeg;
        private double _vDesc;
        private double _vOutro;
        private double _indTot;

        private int _nRECOPI;

        public string xPed { get { return _xPed; } set { _xPed = value; } }
        public int nItemPed { get { return _nItemPed; } set { _nItemPed = value; } }
        public string nFCI { get { return _nFCI; } set { _nFCI = value; } }
        public string cProd { get { return _cProd; } set { _cProd = value; } }
        public string cEAN { get { return _cEAN; } set { _cEAN = value; } }
        public string xProd { get { return _xProd; } set { _xProd = value; } }
        public double NCM { get { return _NCM; } set { _NCM = value; } }
        public string NVE { get { return _NVE; } set { _NVE = value; } }
        public double EXTIPI { get { return _EXTIPI; } set { _EXTIPI = value; } }
        public double CFOP { get { return _CFOP; } set { _CFOP = value; } }
        public string uCom { get { return _uCom; } set { _uCom = value; } }
        public double qCom { get { return _qCom; } set { _qCom = value; } }
        public double vUnCom { get { return _vUnCom; } set { _vUnCom = value; } }
        public double vProd { get { return _vProd; } set { _vProd = value; } }
        public string cEANTrib { get { return _cEANTrib; } set { _cEANTrib = value; } }
        public string uTrib { get { return _uTrib; } set { _uTrib = value; } }
        public double qTrib { get { return _qTrib; } set { _qTrib = value; } }
        public double vUnTrib { get { return _vUnTrib; } set { _vUnTrib = value; } }
        public double vFrete { get { return _vFrete; } set { _vFrete = value; } }
        public double vSeg { get { return _vSeg; } set { _vSeg = value; } }
        public double vDesc { get { return _vDesc; } set { _vDesc = value; } }
        public double vOutro { get { return _vOutro; } set { _vOutro = value; } }
        public double indTot { get { return _indTot; } set { _indTot = value; } }
        public int nRECOPI { get { return _nRECOPI; } set { _nRECOPI = value; } }
    }
}
