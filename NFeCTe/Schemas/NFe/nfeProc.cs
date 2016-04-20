using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Contabil
{
    [XmlRootAttribute("nfeProc", Namespace="http://www.portalfiscal.inf.br/nfe")]
    public class nfeProc
    {
        public NFe2 NFe { get; set; }

        private string _versao;
        [XmlAttribute]
        public string versao { get { return _versao; } set { _versao = value; } }

        public bool Xmlns { get; set; }
        public string nomeArq { get; set; }
              

        public static nfeProc Importar(string caminho)
        {
            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(nfeProc));
                nfeProc nfe = (nfeProc)desserializador.Deserialize(stream);
                return nfe;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        
    }
}
