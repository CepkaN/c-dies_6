using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_6
{
    internal class Bugh
    {
        public double Nalog(Zarplata a)
        {
            double nal = a.CalculateSalary() * 0.13;
            return nal;
        }
    }
}
