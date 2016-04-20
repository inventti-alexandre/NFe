using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace CTe
{
    [XmlRootAttribute("cteProc", Namespace = "http://www.portalfiscal.inf.br/cte")]
    public class cteProc
    {
        public CTe CTe { get; set; }
        public string nomeArq { get; set; } 

        private string _versao;
        [XmlAttribute]
        public string versao { get { return _versao; } set { _versao = value; } }

        public static cteProc Importar(string caminho)
        {
            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(cteProc));
                cteProc cte = (cteProc)desserializador.Deserialize(stream);
                stream.Dispose();
                return cte;
            }
            catch (Exception ex)
            {
                
                return null;
            }

        }
    }
}
