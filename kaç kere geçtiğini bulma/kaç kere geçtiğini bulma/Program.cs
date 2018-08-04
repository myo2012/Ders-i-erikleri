using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;


            Console.Write("metni giriniz= ");
            string metin = Console.ReadLine();
            Console.Write("Aratlıcak olan kelime veya harfi giriniz giriniz=  ");
            string kelime = Console.ReadLine();
            int konum = metin.IndexOf(kelime);

            while (konum != -1)
            {
                konum = metin.IndexOf(kelime, konum + 1);
                sayac++;
            }

            Console.WriteLine("harf veya kelimeden " + sayac.ToString() + " tane vardır");
            Console.ReadKey();

        }
    }
}