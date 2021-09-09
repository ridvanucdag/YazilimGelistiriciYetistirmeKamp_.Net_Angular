using System;

namespace OOP1
{
    class Program
    {

//int,double,bool... değer tip
//diziler,class,abstract class, interface... referans tipler
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product {Id=2,CategoryId=2,
                UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(5, 8);
           int toplamasonucu = productManager.Topla(9, 9);


        }
    }
}
