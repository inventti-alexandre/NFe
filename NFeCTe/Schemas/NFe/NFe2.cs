using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Contabil
{
    [XmlRootAttribute("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NFe2
    {
        public infNFe infNFe;
        public Signature Signature;
    }
}
