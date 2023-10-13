using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_6
{
    internal class SostavFigura2
    {
        public SostavFigura[] mass;
        public int a;
        public double S1;
        public double P1;

        public SostavFigura2(SostavFigura[] mass1, int a1)
        {
            this.mass = mass1;
            this.a = a1;
        }
        public double SSSSS()
        {
            foreach(var s in mass)
            {
                S1 += s.Sss();
            }
            return S1;
        }
        public double PPPPP()
        {
            foreach(var s in mass)
            {
                P1 = s.Perim();
            }
            return P1;
        }
    }
}
