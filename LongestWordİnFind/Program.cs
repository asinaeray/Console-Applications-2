using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordİnFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle Girin: ");
            string metin = Console.ReadLine();

            string[] kelimeler = metin.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string uzunkelime = "";
            foreach (string kelime in kelimeler)
            {
                if (kelime.Length>kelimeler.Length)
                {
                    uzunkelime = kelime;
                }
            }
            Console.Write("En Uzun Kelime: "+uzunkelime);
            Console.ReadKey();
        }
    }
}
