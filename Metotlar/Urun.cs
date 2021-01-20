using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {

        // Propery - özellik
        public int Id { get; set; } //prop tab tab string yaz tab bas Id yaz,  Id bir ürünü diğerinden ayırmaya yarar.

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }
    }
}
