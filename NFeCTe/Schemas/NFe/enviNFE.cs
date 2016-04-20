using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Contabil
{
    public class enviNFe
    {
        [XmlAttribute]
        public List<infNFe> infNFe;
        public idLote idLote;

        public static enviNFe Importar(string caminho)
        {
            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(enviNFe));
                enviNFe nfe = (enviNFe)desserializador.Deserialize(stream);
                return nfe;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
