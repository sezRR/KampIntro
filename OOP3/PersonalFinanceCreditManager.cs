using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Credit Paying Plan Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
