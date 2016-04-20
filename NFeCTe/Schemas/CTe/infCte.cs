using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CTe
{
    public class infCte
    {
        public ide ide;
        public compl compl;
        public emit emit;
        public rem rem;
        public exped exped;
        public receb receb;
        public dest dest;
        public vPrest vPrest;
        public imp imp;
        public infCTeNorm infCTeNorm;
        public infCteComp infCteComp;
        public infCteAnu infCteAnu;

        private double _versao;
        private string _Id;

        [XmlAttribute]
        public double versao { get { return _versao; } set { _versao = value; } }

        [XmlAttribute]
        public string Id { get { return _Id; } set { _Id = value; } }
    }
}
