using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class II
    {
        private int _CST;
        private double _vBC;
        private double _vDespAdu;
        private double _vII;
        private double _vIOF;

        public int CST { get { return _CST; } set { _CST = value; } }
        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double vDespAdu { get { return _vDespAdu; } set { _vDespAdu = value; } }
        public double vII { get { return _vII; } set { _vII = value; } }
        public double vIOF { get { return _vIOF; } set { _vIOF = value; } }
    }
}
