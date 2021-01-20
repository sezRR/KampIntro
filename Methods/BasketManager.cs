using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class BasketManager
    {
        // NAMING CONVENTION
        // SYNTAX

        public void Add1(Product product)
        {
            Console.WriteLine("Process Completed. Product added to basket.\nProduct Name: " + product.ProductName + "\n");
        }

        public void Add2(string productName, string quantityPerUnit, decimal unitPrice, int unitsInStock)
        {
            Console.WriteLine("Process Completed. Product added to basket.\nProduct Name: " + productName + "\n");
        }
    }
}
