using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        // Method Injection
        public void DoAppeal(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            // applicant informations evaluation codes...
            //

            loanManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void DoCreditPreliminaryInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
