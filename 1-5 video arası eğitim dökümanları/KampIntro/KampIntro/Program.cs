using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "Kategori";
            bool sistemegirisyapmismi = true;
            
            Console.WriteLine(kategorietiketi);

            if(sistemegirisyapmismi == true)
            {
                Console.WriteLine("Sisteme hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Lütfen giriş yapınız");
            }

            Person person = new Person()
            {
                ID = 1,
                Name = "Rıdvan",
                SurName = "ÜÇDAĞ",
                Number = 5555555
            };

            Console.WriteLine(person.Name);
        }
    }
}
