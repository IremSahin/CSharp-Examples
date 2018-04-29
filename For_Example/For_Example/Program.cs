using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace For_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-100 aralığındaki çift sayıların toplamını ve ortalaması
            decimal ortalama = 0M;
            decimal toplam = 0M;
            int sayac = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    toplam += i;
                    sayac++;
                }
            }
            ortalama = toplam / sayac;
            Console.Write("Toplam: " + toplam);
            Console.Write("\nOrtalama: " + ortalama);
            Console.ReadKey();
        }
    }
}
