using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_6
{
    internal interface Zarplata
    {
        string? FIO { get; set; }
        int quant { get; set; }
        double CalculateSalary();

    }
}
