using System;
using System.Collections.Generic;
using System.Text;

namespace KampIntro
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler!!Sepete Eklendi: "+ product.Adi);
        }
        public void Ekle2(string Adi , string aciklama , double fiyat,int stokadedi)
        {
            Console.WriteLine("Tebrikler!!Sepete Eklendi: "+Adi);
        }
    }
}
