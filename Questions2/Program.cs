using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions2
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("Doğum Yılını Gir: ");
            int yil = Convert.ToInt32(Console.ReadLine());
            int time = DateTime.Now.Year;
            int hesap = time - yil;
            Console.WriteLine("Yaşınız: "+hesap);
            Console.ReadKey();
            
        }
    }
}
