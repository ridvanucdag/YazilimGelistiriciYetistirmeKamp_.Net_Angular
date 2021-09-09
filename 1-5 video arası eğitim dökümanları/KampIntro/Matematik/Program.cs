using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem();
            dortislem.Topla(8, 9);
            dortislem.Carp(8, 9);

            Console.ReadLine();
        }
    }
}
