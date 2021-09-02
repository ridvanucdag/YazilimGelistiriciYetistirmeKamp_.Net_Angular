using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.ID = 1;
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 55;
            Urun1.Aciklama = "Manisa Elması";
            Urun1.StokAdedi = 25;

            Urun Urun2 = new Urun();
            Urun2.ID = 1;
            Urun2.Adi = "Armut";
            Urun2.Fiyati = 55;
            Urun2.Aciklama = "İstabul Armutu";
            Urun2.StokAdedi = 35;

            Urun[] urunler = new Urun[] 
            { 
            Urun1, Urun2
            };

            foreach(var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("--------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekledim(Urun1);
            sepetManager.Ekledim(Urun2);

            Console.WriteLine("Hello World!");
        }
    }
}
