using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CTe
{
    public class ObsCont
    {
        private string _xCampo;
        private string _xTexto;
        [XmlAttribute]
        public string xCampo { get { return _xCampo; } set { _xCampo = value; } }
        public string xTexto { get { return _xTexto; } set { _xTexto = value; } }
    }
}
