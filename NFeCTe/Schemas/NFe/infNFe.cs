using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Contabil
{
    public class infNFe
    {
        public ide ide;
        public emit emit;
        public avulsa avulsa;
        public dest dest;
        public retirada retirada;
        public entrega entrega;
        public autXML autXML;
        [XmlElement("det")]
        public List<det> det;
        public total total;
        public transp transp;
        public cobr cobr;
        public pag pag;
        public infAdic infAdic;
        public exporta exporta;
        public compra compra;
        public cana cana;


        private string _versao;
        private string _Id;
        private string _nItem;
        [XmlAttribute]
        public string versao { get { return _versao; } set { _versao = value; } }
        [XmlAttribute]
        public string Id { get { return _Id; } set { _Id = value; } }
        public string nItem { get { return _nItem; } set { _nItem = value; } }
                
    }
}
