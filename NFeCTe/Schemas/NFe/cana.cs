using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class cana
    {
        public forDia forDia;
        public deduc deduc;

        private string _safra;
        private string _ref;
        private double _qTotMes;
        private double _qTotAnt;
        private double _qtotGer;
        private double _vFor;
        private double _vTotDed;
        private double _vLiqFor;

        public string safra { get { return _safra; } set { _safra = value; } }
        public string ref1 { get { return _ref; } set { _ref = value; } }
        public double qTotMes { get { return _qTotMes; } set { _qTotMes = value; } }
        public double qTotAnt { get { return _qTotAnt; } set { _qTotAnt = value; } }
        public double qTotGer { get { return _qtotGer; } set { _qtotGer = value; } }
        public double vFor { get { return _vFor; } set { _vFor = value; } }
        public double vTotDed { get { return _vTotDed; } set { _vTotDed = value; } }
        public double vLiqFor { get { return _vLiqFor; } set { _vLiqFor = value; } }
    }
}
