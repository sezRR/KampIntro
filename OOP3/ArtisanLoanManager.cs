using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Artisan Loan Paying Plan Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
