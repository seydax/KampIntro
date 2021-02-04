using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatogeryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 100;
            product1.UnitInStok = 10;

            Product product2 = new Product { Id = 2, CatogeryId=4,ProductName="Kapı",UnitPrice=200,UnitInStok=5 };
            
            ProductManager productManager = new ProductManager();//class tanımlama yapısı
            
            productManager.Add();


        }
    }
}
