using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz: ");
            int deger = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < deger; i++)
            {
                for (int k = i; k < deger; k++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
