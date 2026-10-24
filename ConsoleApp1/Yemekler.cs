using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Yemekler
    {
       public static List<string> corbalar = new List<string> { "Mercimek Çorbası", "Ezogelin Çorbası", "Yayla Çorbası" };
        public static List<double> corbaFiyatlari = new List<double> { 90, 95, 85 };

        public static List<string> salatalar = new List<string> { "Çoban Salata", "Mevsim Salata", "Sezar Salata" };
        public static List<double> salataFiyatlari = new List<double> { 110, 100, 160 };

        public static List<string> makarnalar = new List<string> { "Penne Arrabbiata", "Fettuccine Alfredo", "Spagetti Bolonez" };
        public static List<double> makarnaFiyatlari = new List<double> { 180, 220, 210 };

        public static List<string> etler = new List<string> { "Izgara Köfte", "Kuzu Pirzola", "Dana Antrikot" };
        public static List<double> etFiyatlari = new List<double> { 260, 420, 480 };

        public static List<string> baliklar = new List<string> { "Levrek Izgara", "Çupra Izgara", "Somon Izgara" };
        public static List<double> balikFiyatlari = new List<double> { 340, 330, 390 };

        public static List<string> icecekler = new List<string> { "Kola", "Ayran", "Su" };
        public static List<double> icecekFiyatlari = new List<double> { 50, 35, 20 };
        // 5 adet masa durumu ve hesap takibi
        public static bool[] masaDoluMu = new bool[5];
        public static double[] masaHesaplari = new double[5];

        // Günlük toplam ciro (Z Raporu)
        public static double zRaporuToplam = 0;
    }
}
