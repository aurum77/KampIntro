using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class LoanApplicationManager
    {
        // This is called Method Injection
        public void ApplyToLoan(ILoanManager loanManager, List<ILoggerService> loggerService)
        {
            loanManager.Calculate();
            foreach (var loggers in loggerService)
            {
                loggers.Log();
            }
        }
        public void ShowLoanBriefing(List<ILoanManager> loans)
        {
            foreach(var loan in loans)
            {
                loan.Calculate();
            }

        }
    }
}
