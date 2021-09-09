using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekledim(Urun urun)
        {   
            Console.WriteLine("Tebrikler, Sepete eklendi" +  " : "  +urun.Adi);
        }
    }
}
