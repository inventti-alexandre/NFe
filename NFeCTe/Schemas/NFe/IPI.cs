using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class IPI
    {
        public IPITrib IPITrib;
        public IPINT IPINT;

        private string _clEnq;
        private int _CNPJProd;
        private string _cSelo;
        private double _qSelo;
        private string _cENq;

        private double _vIPIDevol;

        public string clEnq { get { return _clEnq; } set { _clEnq = value; } }
        public int CNPJProd { get { return _CNPJProd; } set { _CNPJProd = value; } }
        public string cSelo { get { return _cSelo; } set { _cSelo = value; } }
        public double qSelo { get { return _qSelo; } set { _qSelo = value; } }
        public string cEnq { get { return _cENq; } set { _cENq = value; } }

        public double vIPIDevol { get { return _vIPIDevol; } set { _vIPIDevol = value; } }
    }
}
