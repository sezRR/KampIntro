using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added to Database.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated on Database.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " deleted on Database.");
        }
    }
}
