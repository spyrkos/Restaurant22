using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SiparisAl
    {
        public static void SiparişAl()
        {

            Console.Clear();
            Console.WriteLine("--- SİPARİŞ ALMA ---");


            int bosMasaIndex = -1;
            for (int i = 0; i < Yemekler.masaDoluMu.Length; i++)
            {
                if (!Yemekler.masaDoluMu[i])
                {
                    bosMasaIndex = i;
                    break;
                }
            }

            if (bosMasaIndex == -1)
            {
                Console.WriteLine("Üzgünüz, tüm masalar dolu!");
                Console.WriteLine("Ana menüye dönmek için bir tuşa basın...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Müşteri Masa {bosMasaIndex + 1}'e yönlendirildi.");
            Yemekler.masaDoluMu[bosMasaIndex] = true;

            int kisiSayisi;
            while (true)
            {
                Console.Write("Kaç kişisiniz? : ");
                if (int.TryParse(Console.ReadLine(), out kisiSayisi) && kisiSayisi > 0)
                    break;
                Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz!");
            }

            for (int kisi = 1; kisi <= kisiSayisi; kisi++)
            {
                Console.WriteLine($"\n--- {kisi}. Müşterinin Siparişi ---");
                bool baskaArzuVarMi = true;

                while (baskaArzuVarMi)
                {
                    Console.WriteLine("\nKategoriler:");
                    Console.WriteLine("1 - Çorbalar");
                    Console.WriteLine("2 - Salatalar");
                    Console.WriteLine("3 - Makarnalar");
                    Console.WriteLine("4 - Etler");
                    Console.WriteLine("5 - Balıklar");
                    Console.WriteLine("6 - İçecekler");
                    Console.Write("Kategori seçiniz (1-6): ");

                    string kategoriSecim = Console.ReadLine();
                    List<string> secilenListe = null;
                    List<double> secilenFiyatlar = null;

                    switch (kategoriSecim)
                    {
                        case "1": secilenListe = Yemekler.corbalar; secilenFiyatlar = Yemekler.corbaFiyatlari; break;
                        case "2": secilenListe = Yemekler.salatalar; secilenFiyatlar = Yemekler.salataFiyatlari; break;
                        case "3": secilenListe = Yemekler.makarnalar; secilenFiyatlar = Yemekler.makarnaFiyatlari; break;
                        case "4": secilenListe = Yemekler.etler; secilenFiyatlar = Yemekler.etFiyatlari; break;
                        case "5": secilenListe = Yemekler.baliklar; secilenFiyatlar = Yemekler.balikFiyatlari; break;
                        case "6": secilenListe = Yemekler.icecekler; secilenFiyatlar = Yemekler.icecekFiyatlari; break;
                        default:
                            Console.WriteLine("Geçersiz kategori seçimi!");
                            continue;
                    }

                    Console.WriteLine("\nÜrünler:");
                    for (int i = 0; i < secilenListe.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {secilenListe[i]} ({secilenFiyatlar[i]} TL)");
                    }

                    Console.Write("Seçmek istediğiniz ürün numarası (1-3): ");
                    if (int.TryParse(Console.ReadLine(), out int urunSecim) && urunSecim >= 1 && urunSecim <= secilenListe.Count)
                    {
                        double eklenenFiyat = secilenFiyatlar[urunSecim - 1];
                        Yemekler.masaHesaplari[bosMasaIndex] += eklenenFiyat;
                        Console.WriteLine($"--> {secilenListe[urunSecim - 1]} siparişe eklendi. (Fiyat: {eklenenFiyat} TL)");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ürün seçimi!");
                        continue;
                    }

                    Console.Write("\nBaşka bir arzunuz var mı? (E/H): ");
                    string cevap = Console.ReadLine().Trim().ToUpper();
                    if (cevap != "E" && cevap != "EVET")
                    {
                        baskaArzuVarMi = false;
                    }
                }
            }

            Console.WriteLine($"\nSipariş tamamlandı. Masa {bosMasaIndex + 1} güncel tutar: {Yemekler.masaHesaplari[bosMasaIndex]} TL");
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
