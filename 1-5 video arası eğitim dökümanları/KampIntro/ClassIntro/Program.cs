using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs = new Kurs()
            {
                ID = 1, KursAdi = "C# Dersleri", KursDetay = "Genel ders eğitimi", KursEgitmen = "Rıdvan ÜÇDAĞ", KursImage = "https://deneme.com", IzlenmeOrani = 100
            };

            Kurs[] kurslar = new Kurs[]
            {
                kurs
            };

            foreach (var kursum in kurslar)
            {
                Console.WriteLine(kursum.KursEgitmen);
            }

            

            // Console.WriteLine(kurs.KursAdi +" "+ kurs.KursEgitmen);
        }
    }

    class Kurs
    {
        public int ID { get; set; }
        public string KursAdi { get; set; }
        public string KursDetay { get; set; }
        public string KursEgitmen { get; set; }
        public string KursImage { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
