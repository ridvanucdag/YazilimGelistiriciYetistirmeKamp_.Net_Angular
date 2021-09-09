using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Birinci kursumuza hoşgeldiniz";
            string kurs2 = "İkinci kursumuza hoşgeldiniz";
            string kurs3 = "Üçüncü kursumuza hoşgeldiniz";
            string kurs4 = "Dördüncü kursumuza hoşgeldiniz";
            // Console.WriteLine(kurs);
            // Console.WriteLine(kurs1);
            // Console.WriteLine(kurs2);

            string[] kurslar = new string[]
            {
                kurs1,kurs2,kurs3,kurs4
            };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Birinci döngü sonudur");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonudur");
        }
    }
}
