using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unlu_harfler
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] unlu = { 'A', 'a', 'e', 'E', 'ı', 'I', 'İ', 'i', 'o', 'O', 'ö', 'Ö', 'u', 'U', 'ü', 'Ü' };
            string metin;
            Console.Write("Metni Giriniz:   ");
            metin = Console.ReadLine();
            foreach (char unluharf in unlu)
            {
                metin = metin.Replace(unluharf.ToString(), "");
            }
            Console.WriteLine(metin);
            Console.ReadKey();
            
        }
    }
}
