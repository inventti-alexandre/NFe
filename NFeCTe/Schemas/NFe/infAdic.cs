using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class infAdic
    {
        public obsCont obsCont;
        public obsFisco obsFisco;
        public procRef procRef;

        private string _infAdFisco;
        private string _infCpf;

        public string infAdFisco { get { return _infAdFisco; } set { _infAdFisco = value; } }
        public string infCpl { get { return _infCpf; } set { _infCpf = value; } }
    }
}
