using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle Giriniz: ");
            string metin = Console.ReadLine();

            string[] kelimeler = metin.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int kelime = kelimeler.Length;
            Console.WriteLine("Kelime Sayısı: "+kelime);
            Console.ReadKey();
        }
    }
}
