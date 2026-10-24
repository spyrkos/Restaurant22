using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Hesap
    {
       public static void HesapAl()
        {
            Console.Clear();
            Console.WriteLine("  \nHESAP ALMA  ");
            Console.Write("  \nHangi masa? 1-5: ");

            if (int.TryParse(Console.ReadLine(), out int masaNo) && masaNo >= 1 && masaNo <= 5)
            {
                int index = masaNo - 1;

                if (!Yemekler.masaDoluMu[index])
                {
                    Console.WriteLine("Bu masa boş");
                }
                else
                {
                    double tutar = Yemekler.masaHesaplari[index];
                    Console.WriteLine($"Masa {masaNo} Toplam Tutar: {tutar} TL");
                    Console.Write("Hesap ödendi mi? E/H: ");
                    string odendiMi = Console.ReadLine().Trim().ToUpper();

                    if (odendiMi == "E" || odendiMi == "EVET")
                    {
                        Yemekler.zRaporuToplam += tutar;
                        Yemekler.masaHesaplari[index] = 0;
                        Yemekler.masaDoluMu[index] = false;

                         for (int i = 0; i < Yemekler.masaDoluMu.Length; i++)
                    {
                        Yemekler.masaDoluMu[i] = false;
                        Yemekler.masaHesaplari[i] = 0;
                    }
                    Console.WriteLine("Tüm masalar sıfırlandı ve boşaltıldı.");
                        Console.WriteLine($"Hesap alındı Masa {masaNo} boşaltıldı");
                    }
                    else
                    {
                        Console.WriteLine("Ödeme alınmadı masa açık kalmaya devam ediyor");
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçersiz masa numarası");
            }


            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
