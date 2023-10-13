using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_6
{
    internal class Menager: Zarplata,Vivod
    {
        public string? FIO { get; set; }
        public int quant { get; set; }
        public Menager(string a,int b) { FIO = a;quant = b; }
        public double CalculateSalary()
        {
            double Zar = quant * 1000;
            return Zar;
        }
        public void Print()
        {
            Console.WriteLine("Менеджер \n ФИО : " + FIO + "\n Кол-во дней : " + quant + "\n Зарплата : " + CalculateSalary());
        }
    }
}
