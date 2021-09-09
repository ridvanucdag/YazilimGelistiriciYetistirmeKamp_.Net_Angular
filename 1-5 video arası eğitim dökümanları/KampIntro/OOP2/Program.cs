using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musterig1 = new GercekMusteri();
            musterig1.Id = 1;
            musterig1.MusteriNo = "12345";
            musterig1.Adi = "Rıdvan";
            musterig1.Soyadi = "Üçdağ";
            musterig1.TcNo = "12345678910";

            TuzelMusteri musterit1 = new TuzelMusteri();
            musterit1.Id = 2;
            musterit1.MusteriNo = "2345678";
            musterit1.SirketAdi = "Üçdağ Yazılım";
            musterit1.VergiNo = "123456987";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musterig1);
            customerManager.Add(musterit1);

            Console.WriteLine("Hello World!");
        }
    }
}
