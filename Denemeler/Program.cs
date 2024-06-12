using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DENEME-1
            // Kullanıcının girmiş olduğu sayının basamak sayısını bul.

            //Console.WriteLine("bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int basamak = 0;
            //while (sayi > 0)
            //{
            //    basamak++;
            //    sayi = sayi / 10;
            //}
            //Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + " basamaklıdır.");

            #endregion
            #region DENEME-2
            //Girilen 2 sayı arasındaki sayıların toplamını bul ortalamsını al

            //int sayi1 = 0, sayi2= 0, toplam = 0, adet = 0;
            //Console.Write("1. sayıyı giriniz:");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 <= sayi2)
            //{
            //    while (sayi1 <= sayi2)
            //    {
            //        Console.Write(sayi1 + "-");
            //        toplam += sayi1;
            //        adet++;
            //        sayi1++;
            //    }
            //    int ort = toplam / adet;
            //    Console.WriteLine("Sayılarının ortalaması = " + ort);
            //}
            //else
            //{
            //    while (sayi2 <= sayi1)
            //    {
            //        Console.Write(sayi2 + "-");
            //        toplam += sayi2;
            //        adet++;
            //        sayi2++;
            //    }
            //    int ort = toplam / adet;
            //    Console.WriteLine("Sayılarının ortalaması = " + ort);
            //}

            #endregion
            #region DENEME-3
            //Kullanıcının girdiği bir sayıyı, başka bi kullanıcıya buldurma kaçıncı tahminde olduğunu söyleme

            //int tahmin = 0;
            //int sayac = 0;
            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int tutulan = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //while (tahmin != tutulan)
            //{
            //    sayac++;
            //    Console.Write("Tahmin giriniz: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin > tutulan)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("AŞAĞI");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("YUKARI");
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine("TAHMİNİNİZ DOĞRU, " + sayac + ". TAHMİNDE BİLDİNİZ ");

            #endregion
            #region DENEME-4
            //1 ile 100 arasındaki tek ve çift sayıların toplamını bulan program


            //int sayi = 0;
            //int toplam = 0;
            //int toplam2 = 0;

            //while (sayi <= 100)
            //{
            //    sayi++;
            //    if (sayi % 2 == 0)
            //    {
            //        toplam = toplam + sayi;
            //    }
            //    else
            //    {
            //        toplam2 = toplam2 + sayi;
            //    }

            //}
            //Console.WriteLine("Çift sayıların toplamı : " + toplam);
            //Console.WriteLine("Tek sayıların toplamı : " + toplam2);
            #endregion
        }

    }
}
