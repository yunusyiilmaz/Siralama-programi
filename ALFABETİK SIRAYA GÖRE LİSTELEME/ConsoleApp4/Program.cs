using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet veri istersiniz :");
            int veri =Convert.ToInt32(Console.ReadLine());
            string[] names=new string[veri];
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write("İSİM GİRİNİZ :");
                string ad = Console.ReadLine();
                names[i] = ad;
            }
            Console.WriteLine();
            Console.WriteLine("NORMAL SIRALANMIŞ HALİ");
            Console.WriteLine();
            foreach(string liste in names)
            {
                Console.WriteLine(liste);
            }
            Console.WriteLine();
            Console.WriteLine("ŞİMDİDE ALFABETİK SIRAYA GÖRE YAPACAĞIZ.");
            Console.WriteLine();
            Array.Sort(names);
            foreach(string liste in names)
            {
                Console.WriteLine(liste);
            }
            Console.WriteLine();
            Console.WriteLine("ŞİMDİ İSE TERSTEN SIRALANMIŞ HALİ");
            Console.WriteLine();
            Array.Reverse(names);
            foreach(string liste in names)
            {
                Console.WriteLine(liste);
            }
            Console.ReadLine();
        }
    }
}
