using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Inheritance (Individual customer is a customer this mean)

    class IndividualCustomer : Customer
    {
        public string IdentityNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
    }
}
