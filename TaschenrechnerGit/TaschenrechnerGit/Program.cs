using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taschenrechner");

            Console.Write("Bitte geben sie eine Zahl ein: ");
            Console.Write("Bitte geben sie eine zweite Zahl ein: ");

            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben sie ein Rechenoperator an: ");
            char rechenoperator = Convert.ToChar(Console.ReadLine());


            switch (rechenoperator)
            {
                case '+':
                    Addition (zahl1, zahl2);
                    break;
                case '-':
                    Subtraktion(zahl1, zahl2);
                    break;
                case '*':
                    Multiplikation(zahl1, zahl2);
                    break;
                case '/':
                    
                    break;
            }
        }

        private static void Multiplikation(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 * zahl2;

            Console.Write(ergebnis);
        }

        private static void Subtraktion(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 - zahl2;

            Console.Write(ergebnis);
        }

        private static void Addition(int zahl1, int zahl2)
        {
            double ergebnis = zahl1 + zahl2;

            Console.Write(ergebnis);
        }
    }
}
