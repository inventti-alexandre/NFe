using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class exporta
    {
        private string _UFSaidaPais;
        private string _xLocExporta;
        private string _xLocDespacho;

        public string UFSaidaPais { get { return _UFSaidaPais; } set { _UFSaidaPais = value; } }
        public string xLocExporta { get { return _xLocExporta; } set { _xLocExporta = value; } }
        public string xLocDespacho { get { return _xLocDespacho; } set { _xLocDespacho = value; } }
    }
}
