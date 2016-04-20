using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CTe
{
    [XmlRootAttribute("cteProc", Namespace = "http://www.portalfiscal.inf.br/cte")]
    public class CTe
    {
        public infCte infCte;
        public Signature Signature;
    }
}
