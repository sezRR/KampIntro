using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Product
    {
        // PROPERTY - ÖZELLİK

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
    }
}
