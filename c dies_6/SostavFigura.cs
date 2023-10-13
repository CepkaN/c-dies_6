using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_6
{
    internal class SostavFigura:ProstNUg
    {
        public double osnovanie { get; set; }
        public double ugOsnSmeg { get; set; }
        public int quant { get; set; }
        public double[] dlinStr { get; set; }
        public double P { get; set; }
        public double S { get; set; }

        public SostavFigura(double []q,int dl)
        {
            dlinStr = q; 
            quant = dl; 

        }
        public double Perim() { 
            foreach(var d in dlinStr)
            {
                P += d;
            }
            return P; }
        public double Sss()
        {
            double p1 = P/2;
            double p2 = P/2;
            foreach(var d in dlinStr)
            {
                p2 *= (p1 - d);
            }
            S = Math.Sqrt(p2);

            return S;
        }
    }
}
