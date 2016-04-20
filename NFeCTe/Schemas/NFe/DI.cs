using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class DI
    {
        public adi adi;

        private string _nDI;
        private string _dDI;
        private string _xLocDesemb;
        private string _UFDesemb;
        private string _dDesemb;
        private int _tpViaTransp;
        private double _vAFRMM;
        private int _tpIntermedio;
        private string _CNPJ;
        private string _UFTerceiro;
        private string _cExportador;

        public string nDI { get { return _nDI; } set { _nDI = value; } }
        public string dDI { get { return _dDI; } set { _dDI = value; } }
        public string xLocDesemb { get { return _xLocDesemb; } set { _xLocDesemb = value; } }
        public string UFDesemb { get { return _UFDesemb; } set { _UFDesemb = value; } }
        public string dDesemb { get { return _dDesemb; } set { _dDesemb = value; } }
        public int tpViaTransp { get { return _tpViaTransp; } set { _tpViaTransp = value; } }
        public double vAFRMM { get { return _vAFRMM; } set { _vAFRMM = value; } }
        public int tpIntermedio { get { return _tpIntermedio; } set { _tpIntermedio = value; } }
        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public string UFTerceiro { get { return _UFTerceiro; } set { _UFTerceiro = value; } }
        public string cExportador { get { return _cExportador; } set { _cExportador = value; } }
    }
}
