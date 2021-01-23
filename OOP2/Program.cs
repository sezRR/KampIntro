using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.CustomerId = 1;
            individualCustomer1.CustomerNumber = "12345";
            individualCustomer1.CustomerFirstName = "Engin";
            individualCustomer1.CustomerLastName = "Demiroğ";
            individualCustomer1.IdentityNumber = "12345678910";

            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.CustomerId = 2;
            corporateCustomer1.CustomerNumber = "54321";
            corporateCustomer1.CompanyName = "Kodlama.io";
            corporateCustomer1.TaxNumber = "1234567890";

            // Individual (Person) Customer - Corporate Customer
            // * SO - "L" - ID

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer1);
            customerManager.Add(corporateCustomer1);
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
