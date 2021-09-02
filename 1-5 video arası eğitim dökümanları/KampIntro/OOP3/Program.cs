using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            IKrediManager konutKrediManager1 = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerServise();
            ILoggerService fileLoggerService = new FileLoggerServise();


            List<ILoggerService> logger = new List<ILoggerService> { new DatabaseLoggerServise(), new FileLoggerServise() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager1,logger); //,new List<ILoggerService> {new DatabaseLoggerServise(),new FileLoggerServise() });

            

            List<IKrediManager> krediManager = new List<IKrediManager>() { konutKrediManager1, tasitKrediManager1 };
            
            
            //basvuruManager.KrediOnBilgilendirmeYap(krediManager);
            Console.WriteLine("Hello World!");
        }
    }
}
