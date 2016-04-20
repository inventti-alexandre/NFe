using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class compra
    {
        private string _xNEmp;
        private string _xPed;
        private string _xCont;

        public string xNEmp { get { return _xNEmp; } set { _xNEmp = value; } }
        public string xPed { get { return _xPed; } set { _xPed = value; } }
        public string xCont { get { return _xCont; } set { _xCont = value; } }
    }
}
