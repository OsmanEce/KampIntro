using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Snippet - hazır kodlar demek
    class Product // Bu tip class larda sadece özellik olur.
    {
        public int Id { get; set; } // Ana anahtar burası
        public int CategoryId { get; set; }  // bu bi referans alanı, referans anahtarı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; } // ürünün stok adedi

        //CRUD operasyon
    }
}
