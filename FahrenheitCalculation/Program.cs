using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dereceyimi Dönüştürelim Fahrenietı mı? (D/F) ");
            string cevap = Console.ReadLine();
            if (cevap=="D"||cevap=="d")
            {
                Console.WriteLine("Dereceyi Girin: ");
                int c = Convert.ToInt32(Console.ReadLine());
                double fah = c * 1.8 + (32);
                Console.WriteLine("Cevap = " + fah + " F");
              
            }
            else if (cevap=="F"||cevap=="f")
            {
                Console.WriteLine("Fahı Girin: ");
                int f = Convert.ToInt32(Console.ReadLine());
                double c = (f - 32) / 1.8;
                Console.WriteLine("Cevap = " + c + " D");

            }

            Console.ReadKey();

        }
    }
}
