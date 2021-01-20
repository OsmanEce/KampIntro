using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        //syntax
        public void Ekle(Urun urun) // pythonda ki def
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi) // bu iyi bir yazma şekli değil.
        {
        Console.WriteLine("Tebrikler.Sepete eklendi! : " +urunAdi);
        }


     }


}

