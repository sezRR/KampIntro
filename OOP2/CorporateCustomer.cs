using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Inheritance (Corporate customer is a customer this mean)

    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
