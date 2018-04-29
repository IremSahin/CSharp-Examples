using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sayı tahmin oyunu

            Random rnd = new Random();
            int sayi = rnd.Next(50, 100);
            int sayac = 0;
            int hak = 10;
            int tsayi;
            Console.Write(sayi + "\n");
            while (sayac < hak)
            {
                Console.Write(hak + " tahmin hakkınız bulunmakta. Tahmininizi giriniz: ");
                tsayi = Convert.ToInt32(Console.ReadLine());
                hak--;
                
                if (sayi == tsayi)
                {
                    Console.Write("TEBRİKLER DOĞRU TAHMİN ETTİNİZ..");
                    break;
                }
            }

            if (sayac == hak)
            {
                Console.Write("DOĞRU SAYIYI BULAMADINIZ..");
                Console.Write("\nTahmin edilmesi gereken: " + sayi);
            }

            Console.ReadKey();
        }
    }
}
