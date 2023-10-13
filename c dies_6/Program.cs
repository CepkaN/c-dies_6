namespace c_dies_6
{

    interface IInterface
    {
        static IInterface() { }
        const int a = 10;
        // int b;  полей не может быть, только константы и статик-поля
        static int b;
        int C { get; set; }
        void Ball();
    }
    interface IInter2
    {

    }
    class CL { }
    class CL2 {
        public int Sell(int abc) => abc * 25;
    }
    class CL3:CL,IInterface,IInter2 {
        private int abc { get; set; }
        public int Abc { get; set; }
        public int C { get; set; } 
        public void Ball() { }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Интерфейсы
            /* Menager menag = new Menager("Menager", 20);
             Shef shef = new Shef("Shef", 20);
             Bugh bugh = new Bugh();

             menag.Print();
             Console.WriteLine(" Налог " + bugh.Nalog(menag));

             shef.Print();
             Console.WriteLine(" Налог " + bugh.Nalog(shef));*/

            double[] db=new double[5] { 2, 4, 5, 3, 2 };
            SostavFigura sost = new SostavFigura(db, 5);
            Console.WriteLine(sost.Perim());
            Console.WriteLine( sost.Sss());

            Console.WriteLine();

            double[]db1=new double[3] { 3,5,7};
            SostavFigura sost1 = new SostavFigura(db1, 3);
            double[] db2 = new double[7] { 3, 5, 7, 2, 1, 3, 4 };

            SostavFigura sost2 = new SostavFigura(db2, 7);

            SostavFigura[] sostavMass = new SostavFigura[3] { sost1, sost2, sost };

            SostavFigura2 massS = new SostavFigura2(sostavMass, 3);
            Console.WriteLine(massS.PPPPP());
            Console.WriteLine(massS.SSSSS());

        }
    }
}