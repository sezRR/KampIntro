using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Loan Paying Plan Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
