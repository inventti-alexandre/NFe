using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTe
{
    public class enderReceb
    {
        private string _xLgr;
        private string _nro;
        private string _xCpl;
        private string _xBairro;
        private int _cMun;
        private string _xMun;
        private string _UF;
        private int _CEP;
        private string _cPais;
        private string _xPais;
        private string _email;

        public string xLgr { get { return _xLgr; } set { _xLgr = value; } }
        public string nro { get { return _nro; } set { _nro = value; } }
        public string xCpl { get { return _xCpl; } set { _xCpl = value; } }
        public string xBairro { get { return _xBairro; } set { _xBairro = value; } }
        public int cMun { get { return _cMun; } set { _cMun = value; } }
        public string xMun { get { return _xMun; } set { _xMun = value; } }
        public string UF { get { return _UF; } set { _UF = value; } }
        public int CEP { get { return _CEP; } set { _CEP = value; } }
        public string cPais { get { return _cPais; } set { _cPais = value; } }
        public string xPais { get { return _xPais; } set { _xPais = value; } }
        public string email { get { return _email; } set { _email = value; } }
    }
}
