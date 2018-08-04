using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazının_tersten_esitligi_kntrl_etme
{
    class Program
    {
        static void Main(string[] args)
        {

            string metin;
            string metinters = "";
            Console.Write("Metni Giriniz= ");
            metin = Console.ReadLine();
            foreach (char harf in metin)
            {
                metinters = harf.ToString() + metinters;

            }
           Console.WriteLine(metinters);

            if (metinters==metin)
            {
                Console.WriteLine("Metin Eşittir");
            }
            else
            {
                Console.WriteLine("Metin Eşit Değildir");
            }

             Console.ReadKey();

        }
    }
}
