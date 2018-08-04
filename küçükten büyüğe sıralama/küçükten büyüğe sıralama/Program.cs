using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace küçükten_büyüğe_sıralama
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi;
            Console.WriteLine("kaç sayı girileceğini yazınız");
            sayi = int.Parse(Console.ReadLine());

            int[] sayilar = new int[sayi];
            for (int i = 0; i < sayi; i++)
            { 
             Console.Write((i+1).ToString() +".Sayı giriniz = ");
             sayilar[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sayilar);
            Console.WriteLine("Küçükten Büyüğe Sıralama Böyle");

            foreach (int i in sayilar)
            {

                Console.Write(" < {0}", i);

            }

            Console.ReadKey(); 
        }
    }
}
