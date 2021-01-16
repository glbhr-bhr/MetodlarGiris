using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double fiyati1 = 15;
            string acıklma1 = "Amasya";

            

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] Urunler = new Urun[] {urun1,urun2 };

            //type safe--tip güvenli
            foreach (Urun urun in Urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }
                
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------METHOTLAR--------------------");

            maneger maneger = new maneger();


            maneger.Ekle(urun1);
            maneger.Ekle(urun2);
        

        }
    }
}
