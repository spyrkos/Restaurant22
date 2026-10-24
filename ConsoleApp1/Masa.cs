using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Masa
    {
      public  static void MasaDurumu()
        {
            Console.Clear();
            Console.WriteLine("\n  MASA DURUMLARI");
            for (int i = 0; i < Yemekler.masaDoluMu.Length; i++)
            {
                string durum = Yemekler.masaDoluMu[i] ? $"DOLU (Tutar: {Yemekler.masaHesaplari[i]} TL)" : "BOŞ";
                Console.WriteLine($"Masa {i + 1}: {durum}");
            }
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();

        }
    }
}
