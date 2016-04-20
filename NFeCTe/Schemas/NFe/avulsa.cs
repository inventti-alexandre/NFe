using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class avulsa
    {
        private string _CNPJ;
        private string _xOrgao;
        private string _matr;
        private string _xAgente;
        private int _fone;
        private string _UF;
        private string _nDAR;
        private string _dEmi;
        private int _vDAR;
        private string _repEmi;
        private string _dPag;

        public string CNPJ { get { return _CNPJ; } set { _CNPJ = value; } }
        public string xOrgao { get { return _xOrgao; } set { _xOrgao = value; } }
        public string matr { get { return _matr; } set { _matr = value; } }
        public string xAgente { get { return _xAgente; } set { _xAgente = value; } }
        public int fone { get { return _fone; } set { _fone = value; } }
        public string UF { get { return _UF; } set { _UF = value; } }
        public string nDAR { get { return _nDAR; } set { _nDAR = value; } }
        public string dEmi { get { return _dEmi; } set { _dEmi = value; } }
        public int vDAR { get { return _vDAR; } set { _vDAR = value; } }
        public string repEmi { get { return _repEmi; } set { _repEmi = value; } }
        public string dPag { get { return _dPag; } set { _dPag = value; } }
    }
}
