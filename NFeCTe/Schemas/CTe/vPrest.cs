using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CTe
{
    public class vPrest
    {
        [XmlElement("Comp")]
        public List<Comp> Comp;

        private double _vTPrest;
        private double _vRec;

        public double vTPrest { get { return _vTPrest; } set { _vTPrest = value; } }
        public double vRec { get { return _vRec; } set { _vRec = value; } }
    }
}
