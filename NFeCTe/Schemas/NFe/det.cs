using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Contabil.Schema;

namespace Contabil
{
    public class det
    {
        public prod prod;
        public imposto imposto;
        public impostoDevol impostoDevol;

        private int _nItem;
        private string _infAdProd;

        [XmlAttribute]
        public int nItem { get { return _nItem; } set { _nItem = value; } }
        public string infAdProd { get { return _infAdProd; } set { _infAdProd = value; } }
    }
}
