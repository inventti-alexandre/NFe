using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CTe
{
    public class infModal
    {
        private string _versaoModal;

        [XmlAttribute]
        public string versaoModal { get { return _versaoModal; } set { _versaoModal = value; } }
    }
}
