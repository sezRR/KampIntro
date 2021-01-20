using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new();
            product1.ProductId = 1;
            product1.CategoryId = 2; // Furnitures in database (just simulated for now)
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { ProductId = 2, CategoryId = 5, ProductName = "Pencil", UnitPrice = 2, UnitsInStock = 5 }; // Category 5 is stationery in database (just simulated for now)

            // Instance Creation
            ProductManager productManager = new(); // The left side is stack on the memory, The right side is heap on the memory
            productManager.Add(product1);
        }
    }
}
