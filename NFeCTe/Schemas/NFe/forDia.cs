using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Contabil
{
    public class forDia
    {
        private int _dia;
        private double _qtde;

        [XmlAttribute]
        public int dia { get { return _dia; } set { _dia = value; } }
        public double qtde { get { return _qtde; } set { _qtde = value; } }
    }
}
