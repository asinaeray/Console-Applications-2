using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyİndexCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double index = 0;
            Console.WriteLine("Boyunuzu Giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilonuzu Giriniz: ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            index = kilo/(boy * boy);
            if (index<=18.5)
            {
                Console.WriteLine("Vücut Kitle İndexiniz: " + index);
                Console.WriteLine("Durumunuz: Zayıf");
            }
            else if (index>18.5&&index<=24.9)
            {
                Console.WriteLine("Vücut Kitle İndexiniz: " + index);
                Console.WriteLine("Durumunuz: Normal");
            }
            else if (index>=25&&index<=20.9)
            {
                Console.WriteLine("Vücut Kitle İndexiniz: " + index);
                Console.WriteLine("Durumunuz: Fazla Kilolu");
            }
            else if (index >= 30 && index <= 34.9)
            {
                Console.WriteLine("Vücut Kitle İndexiniz: " + index);
                Console.WriteLine("Durumunuz: Obez(1.derece)");
            }
            else if (index >= 35 && index <= 39.9)
            {
                Console.WriteLine("Vücut Kitle İndexiniz: " + index);
                Console.WriteLine("Durumunuz: Aşırı Obez(2.derece)");
            }
            else if (index >= 40)
            {
                Console.WriteLine("Vücut Kitle İndexiniz: " + index);
                Console.WriteLine("Durumunuz: Morbid Obez(3.derece)");
            }
            else
            {
                Console.WriteLine("Hata");
            }


            Console.ReadKey();
        }
    }
}
