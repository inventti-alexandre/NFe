using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class detExport
    {
        public exportInd exportInd;

        private string _nDraw;

        public string nDraw { get { return _nDraw; } set { _nDraw = value; } }
    }
}
