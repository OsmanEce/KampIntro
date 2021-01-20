using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id =2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice = 35 }; //bu şekildede oluşturabilirim. Yukardakinden farklı

            // PascalCase   // camelCase  //case sensitive (küçük büyük harf duyarlı).
            ProductManager productManager = new ProductManager(); // ProductManager türünde productManager(buna x desende olur) oluşturuyoruz. // sol taraf stack sağ taraf heap bellekte
            //string isim;  // String türünde isim
            productManager.Add(product1); //buna parametre diyoruz. 
            // ref out

        }
    }
}
