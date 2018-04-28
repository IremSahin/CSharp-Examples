using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alistirmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçli tür dönüşümü
            decimal sayi1 = 10;
            int sayi2 = (int)sayi1;
            Console.WriteLine("Bilinçli tür dönüşümü sayı değeri: {0}", sayi2);

            //Blinçsiz tür dönüşümü
            int sayi3 = 20;
            decimal sayi4 = sayi3;
            Console.WriteLine("Bilinçsiz tür dönüşümü sayı değeri: {0}", sayi4);

            //Boxing
            Ogrenci o1 = new Ogrenci();
            o1.isim = "İrem";
            Object o2 = o1;
            Console.WriteLine("Boxing işlemi: {0}", o2);

            //Unboxing
            o1 = (Ogrenci)o2;
            Console.WriteLine("Unboxing işlemi: {0}", o1);

            Console.ReadKey();
        }
    }

    class Ogrenci
    {  
        public string isim { get; set; }
        public override string ToString()
        {
            return this.isim;
        }
    }
}
