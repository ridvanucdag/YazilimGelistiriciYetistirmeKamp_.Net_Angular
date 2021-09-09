using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            var toplam = sayi1 + sayi2;

            Console.WriteLine("Sonuç : " + toplam);
        }

        public void Carp (int sayi1 ,int sayi2)
        {
            var carpim = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + carpim);
        }
    }
}
