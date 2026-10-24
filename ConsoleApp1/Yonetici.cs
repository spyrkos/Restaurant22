using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Yonetici
    {
       public static void YoneticiGirisi()
        {
            Console.Clear();
            Console.WriteLine("--- YÖNETİCİ PANELİ ---");
            Console.WriteLine("1 - Z Raporunu Sıfırla");
            Console.WriteLine("2 - Tüm Masaları Boşalt");
            Console.WriteLine("3 - Geri Dön");
            Console.Write("Seçiminiz: ");

            string yoneticiSecim = Console.ReadLine();
            switch (yoneticiSecim)
            {
                case "1":
                    Yemekler.zRaporuToplam = 0;
                    Console.WriteLine("Z Raporu sıfırlandı.");
                    break;
                case "2":
                    for (int i = 0; i < Yemekler.masaDoluMu.Length; i++)
                    {
                        Yemekler.masaDoluMu[i] = false;
                        Yemekler.masaHesaplari[i] = 0;
                    }
                    Console.WriteLine("Tüm masalar sıfırlandı ve boşaltıldı.");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
