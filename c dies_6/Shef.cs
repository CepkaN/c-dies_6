using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_6
{
    internal class Shef: Zarplata,Vivod
    {
        public string? FIO { get; set; }
        public int quant { get; set; }
        public Shef(string a,int b)
        {
            FIO = a;quant = b;
        }
        public double CalculateSalary()
        {
            double Zar = quant * 2500;
            return Zar;
        }
        public void Print()
        {
            Console.WriteLine("Глава отдела \n ФИО : " + FIO + "\n Кол-во дней : " + quant + "\n Зарплата : " + CalculateSalary());
        }

    }
}
