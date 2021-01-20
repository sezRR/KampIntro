using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.UnitPrice = 15;
            product1.QuantityPerUnit = "Just an Apple";

            Product product2 = new Product();
            product2.ProductName = "Watermelon";
            product2.UnitPrice = 80;
            product2.QuantityPerUnit = "An Watermelon of Diyarbakir";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.QuantityPerUnit);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("\n------------METHODS------------");

            // Instance: Örnek
            // ENCAPSULATION

            BasketManager basketManager = new BasketManager();
            basketManager.Add1(product1);
            basketManager.Add1(product2);

            basketManager.Add2("Pear", "A green Pear", 12, 10);
            basketManager.Add2("Apple", "A green Apple", 14, 9);
            basketManager.Add2("Watermelon", "An Watermelon of Diyarbakir", 18, 8);
        }
    }
}

// DO NOT REPEAT YOURSELF - DRY
// CLEAN CODE
// BEST PRACTICE