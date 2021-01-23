using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport Credit Paying Plan Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
