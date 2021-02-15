using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // An interface can hold the classes that implemented it
            ILoanManager consumerLoanManager = new ConsumerLoanManager();

            ILoanManager vehicleLoanManager = new VehicleLoanManager();

            ILoanManager houseLoanManager = new HouseLoanManager();

            LoanApplicationManager loanApplicationManager = new LoanApplicationManager();
            // We can give the classes above as parameter to first parameter
            // of this method. Also we can create an object as a paramater
            // if we wanted to like:

            // loanApplicationManager.ApplyToLoan(vehicleLoanManager, new FileLoggerService() );

            // or we can just instantiate an object seperately and pass it that way
            FileLoggerService fileLoggerService = new FileLoggerService(); 

            // Interfaces make software easier to maintain as i can make a million different
            // types of loans without needing to change a single code other than adding them
            loanApplicationManager.ApplyToLoan(vehicleLoanManager, new List<ILoggerService> { new DatabaseLoggerService() } );

            // Adding a new loan type is as easy as creating a new class, setting it to inherit
            // ILoanManager, implementing interface and adding the functions
            List<ILoggerService> loggerServices = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService()};
            loanApplicationManager.ApplyToLoan(new TradeLoanManager(), loggerServices );

            List<ILoanManager> loans = new List<ILoanManager>() { consumerLoanManager, vehicleLoanManager};

            // loanApplicationManager.ShowLoanBriefing(loans);
        }
    }
}
