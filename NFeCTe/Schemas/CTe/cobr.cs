using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CTe
{
    public class cobr
    {
        public fat fat;
        [XmlElement("dup")]
        public List<dup> dup;
    }
}
