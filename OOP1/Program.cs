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
            product1.UnitInStock = 3;

            //ya da şu şekilde de oluşturabilirdik. 
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = " Kalem ", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            //productmanager türünde productmanager 
            //ilki PascalCase(ilk harfler büyük.)
            //İkincisi camelCase(ikinci harfler büyük.)
            //C# case senstive.
            productManager.Add(product1); //tam burada productmanager classına gidilir.
            Console.WriteLine(product1.ProductName);
            //NOT: Sayısallar(int,double,bool..) değer tiptir
            //diziler, class, abstract class, interface referand tiptir.


        }
    }
}