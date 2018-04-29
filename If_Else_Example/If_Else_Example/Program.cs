using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace If_Else_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Çıkartma");
            Console.WriteLine("3.Çarpma");
            Console.WriteLine("4.Bölme");
            Console.Write("İşlem seçiniz: ");
            
            int secim=Convert.ToInt32(Console.ReadLine());
            int sonuc;

            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("İşlem sonucu: "+sonuc);
            }
            else if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("İşlem sonucu: "+sonuc);

            }
            else if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("İşlem sonucu: "+sonuc);
            }
            else if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("İşlem sonucu: "+sonuc);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız..");
            }

            Console.ReadKey();
        }
    }
}
