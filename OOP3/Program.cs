using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonalFinanceCreditManager personalFinanceCreditManager1 = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager1.Calculate();

            //TransportCreditManager transportCreditManager1 = new TransportCreditManager();
            //transportCreditManager1.Calculate();

            //MortgageLoanManager mortgageLoanManager1 = new MortgageLoanManager();
            //mortgageLoanManager1.Calculate();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            ILoanManager personalFinanceCreditManager2 = new PersonalFinanceCreditManager();
            ILoanManager transportCreditManager2 = new TransportCreditManager();
            ILoanManager mortgageLoanManager2 = new MortgageLoanManager();

            AppealManager appealManager = new AppealManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            appealManager.DoAppeal(mortgageLoanManager2, loggers);
            //appealManager.DoAppeal(new ArtisanLoanManager(), new List<ILoggerService> { databaseLoggerService, smsLoggerService });

            // Polymorphism

            List<ILoanManager> loans = new List<ILoanManager>() { personalFinanceCreditManager2, transportCreditManager2 };

            //appealManager.DoCreditPreliminaryInformation(loans);
        }
    }
}
