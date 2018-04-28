using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] sayi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                sayi[i] = rnd.Next(10,50);
            }

            foreach (var item in sayi)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
