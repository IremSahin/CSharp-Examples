using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarpmaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1 ;
            string sayi2 ;
  
            Console.Write("Bir sayi giriniz: ");
            sayi1 = Console.ReadLine();
            Console.Write("Bir sayi giriniz: ");
            sayi2 = Console.ReadLine();
            
            Islem(sayi1, sayi2);

            Console.ReadKey();
        }

        private static void Islem(string sayi1, string sayi2)
        {
            int[] sayi1dizi = new int[sayi1.Length];
            for (int i = 0; i < sayi1.Length; i++)
            {
                sayi1dizi[i] = (int.Parse(sayi1[i].ToString()));
            }

            int[] sayi2dizi = new int[sayi2.Length];
            for (int i = 0; i < sayi2.Length; i++)
            {
                sayi2dizi[i] = (int.Parse(sayi2[i].ToString()));
            }

            int basamak;
            int toplamtoplanacak;

            if (sayi1.Length > sayi2.Length)
	        {
		        basamak = sayi1.Length;
                toplamtoplanacak = sayi2.Length;
	        }
            else
	        {
                basamak=sayi2.Length;
                toplamtoplanacak = sayi1.Length;
	        }

            string deger = "";
            string[] toplanacak = new string[toplamtoplanacak];
            string basamakCarpim;
            string elde = "0";
            string degerSon = "";
            
            for (int i = sayi2dizi.Length - 1; i >= 0; i--)
            {
                deger = "";
                elde = "0";
                degerSon = "";
                for (int j = sayi1dizi.Length - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {                       
                        basamakCarpim = Convert.ToString(sayi2dizi[i] * sayi1dizi[j]);
                        deger = (int.Parse(elde) + int.Parse(basamakCarpim)).ToString();
                        char[] tersCevir = deger.ToCharArray();
                        Array.Reverse(tersCevir);
                        deger = new String(tersCevir); 
                        degerSon += deger;
                    }

                    if(j != 0)
                    {
                        basamakCarpim = Convert.ToString(sayi2dizi[i] * sayi1dizi[j]);
                        deger = (int.Parse(elde) + int.Parse(basamakCarpim)).ToString();
                        elde = "0";
                        for (int k = 0; k < deger.Length-1; k++)
                        {
                            elde += deger[k];
                        }

                        deger = deger[deger.Length - 1].ToString();
                        degerSon += deger;
                    }                  
                }
                
                toplanacak[sayi2dizi.Length - (i+1)] = Convert.ToString(degerSon); 
            }

            for (int i = 0; i < toplanacak.Length; i++)
            {
                Console.WriteLine(toplanacak[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < toplanacak.Length; i++)
            {
                char[] tersCevir = toplanacak[i].ToCharArray();
                Array.Reverse(tersCevir);
                toplanacak[i] = new String(tersCevir);

                for (int j = 0; j < i; j++)
                {
                    toplanacak[i] += "0";
                }
            }

            for (int j = 0; j < toplanacak.Length-1; j++)
            {
                if (toplanacak[j].Length != toplanacak[toplanacak.Length-1].Length)
                {
                    int eksikSifir = toplanacak[toplanacak.Length - 1].Length - toplanacak[j].Length;
                    for (int k = 0; k < eksikSifir; k++)
                    {
                        toplanacak[j] = "0" + toplanacak[j];
                    }
                }
            }

            for (int i = 0; i < toplanacak.Length; i++)
            {
                Console.WriteLine(toplanacak[i]);
            }

            Console.WriteLine();

            string indis = "0";
            elde = "0";
            deger = "0";
            degerSon = "";

            for (int i = toplanacak[toplanacak.Length - 1].Length-1; i >= 0 ; i--)
            {
                deger = "0";

                for (int j = 0; j < toplanacak.Length; j++)
                {
                    indis = toplanacak[j];
                    deger = (int.Parse(deger) + int.Parse(indis[i].ToString())).ToString();
                }

                deger = (int.Parse(deger) + int.Parse(elde)).ToString();
                
                if (i == 0)
                {
                    char[] tersCevir = deger.ToCharArray();
                    Array.Reverse(tersCevir);
                    deger = new String(tersCevir);
                    degerSon += deger;
                }

                if (i != 0)
                {
                    elde = "0";

                    for (int k = 0; k < deger.Length - 1; k++)
                    {
                        elde += deger[k];
                    }

                    deger = deger[deger.Length - 1].ToString();
                    degerSon += deger;
                }
            }
            
            char[] sonucTersCevir = degerSon.ToCharArray();
            Array.Reverse(sonucTersCevir);
            degerSon = new String(sonucTersCevir);
            
            Console.WriteLine(degerSon);
        }
    }
}