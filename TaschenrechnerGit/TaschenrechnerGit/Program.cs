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

            double zahl1 = 0;
            double zahl2 = 0;
            bool exception = false;
            char rechenoperator = '#';
            do
            {
                try
                {
                    Console.Write("Geben sie ein Rechenoperator an: ");
                    rechenoperator = Convert.ToChar(Console.ReadLine());

                    if (rechenoperator != '+' && rechenoperator != '-' && rechenoperator != '*' && rechenoperator != '/')
                    {
                        throw new Exception("RECHENOPERATOR (+|-|*|/), drück ENTER erst");
                    }

                    Console.Write("Bitte geben sie eine Zahl ein: ");
                    zahl1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Bitte geben sie eine zweite Zahl ein: ");
                    zahl2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    exception = true;
                    Console.Clear();
                }
              
            } while (exception == true);





           
            


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
                    Division(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadLine();
        }

        private static void Division(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 / zahl2;

            Console.Write("Ergebnis: " + ergebnis);
        }

        private static void Multiplikation(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 * zahl2;

            Console.Write("Ergebnis: " + ergebnis);
        }

        private static void Subtraktion(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 - zahl2;

            Console.Write("Ergebnis: " + ergebnis);
        }

        private static void Addition(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 + zahl2;

            Console.Write("Ergebnis: " + ergebnis);
        }



    }
}
