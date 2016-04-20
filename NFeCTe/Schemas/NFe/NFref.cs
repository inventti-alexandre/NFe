using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class NFref
    {
        public refNF refNF;
        public refNFP refNFP;
        public refECF refECF;

        private string _refNFe;

        public string refNFe { get { return _refNFe; } set { _refNFe = value; } }
    }
}
