using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace _16_Restaurant_Otomasyonu
{
    internal class Program
    {
        
      

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
            
                Console.WriteLine("       \n\r RESTAURANT OTOMASYONU           ");
         
                Console.WriteLine("1 - Sipariş Al");
                Console.WriteLine("2 - Hesap Al");
                Console.WriteLine("3 - Masa Durum");
                Console.WriteLine("4 - Z Rapor");
                Console.WriteLine("5 - Çıkış");
                Console.WriteLine("999 - Yönetici Girişi");
                Console.Write("Seçiminiz: "); 

                string secim = Console.ReadLine();

                while(true)
                {
                    if( secim == "1")
                    {
                        SiparisAl.SiparişAl();
                        break;
                    }
                    else if (secim == "2")
                    {
                        Hesap.HesapAl();
                        break;

                    }


                    else if (secim == "3")
                    {
                        Masa.MasaDurumu();
                        break;

                    }
                    else if (secim == "4")
                    {
                        Zrapor.ZRaporuGoster();
                        break;

                    }
                    else if (secim == "5")
                    {
                        Console.WriteLine("Program kapatılıyor...");
                        return;

                    }

                    else if (secim == "999")
                    {
                        Yonetici.YoneticiGirisi();
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim! Devam etmek için bir tuşa basın...");
                        break;
                    }

                }
            }
        }

      

       

       

       

       
    }
}