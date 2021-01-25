﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati =15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 13;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 18;

            Urun[] urunler = new Urun[] {urun1,urun2};

            // type-safe -- tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+ urun.Aciklama + urun.Fiyati);
                Console.WriteLine("**  **  **");
            }

            Console.WriteLine("--Metotlar---");
            // instance - örnek
            // encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80,8);
        }
    }
}



/* 
 * Do not repeat yourself - DRY 
 * Clean Code
 * Best Practice
*/