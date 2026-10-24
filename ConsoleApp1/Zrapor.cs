using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Zrapor
    {
       public static void ZRaporuGoster()
        {
            Console.Clear();
            Console.WriteLine("--- GÜNLÜK Z RAPORU ---");
            Console.WriteLine($"Kasaya Giren Toplam Tutar: {Yemekler.zRaporuToplam} TL");
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
