using System;

namespace OOP3
{
    class FileLoggerServise : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
