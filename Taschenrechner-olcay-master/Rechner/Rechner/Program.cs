using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rechner
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Was wollen sie rechnen? 1 = + , 2 = - , 3 = * , 4 = / ,5 = wurzel, 6 = quadrat");
            int z = Convert.ToInt32(Console.ReadLine());
            string a = "geben sie eine zahl ein :";
            double x = 0;
            double y = 0;
            if (z== 5||z==6)
            {
                Console.WriteLine(a);
                x = Convert.ToDouble(Console.ReadLine());
            }
            if (z>=1&&z<=4)
            {
                Console.WriteLine(a);
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a);
                y = Convert.ToDouble(Console.ReadLine());
            }
            

            if (z == 1)
            {
                double ergebniss = x + y;
                Console.WriteLine("Ihr ergebniss ist = " + ergebniss);
                Console.ReadLine();
            }
            else if (z == 2)
            {
                double ergebniss = x - y;
                Console.WriteLine("Ihr ergebniss ist = " + ergebniss);
                Console.ReadLine();
            }
            else if (z == 3)
            {
                double ergebniss = x * y;
                Console.WriteLine("Ihr ergebniss ist = " + ergebniss);
                Console.ReadLine();
            }
            else if (z == 4)
            {
                double ergebniss = x / y;
                Console.WriteLine("Ihr ergebniss ist = " + ergebniss);
                Console.ReadLine();
            }
            else if (z == 5)
            {
                double ergebniss = Math.Sqrt(x) ;
                Console.WriteLine("Ihr ergebniss ist = " + ergebniss);
                Console.ReadLine();
            }
            else if (z == 6)
            {
                double ergebniss = x*x;
                Console.WriteLine("Ihr ergebniss ist = " + ergebniss);
                Console.ReadLine();
            }

        }
    }
}
