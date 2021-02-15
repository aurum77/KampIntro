using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradeLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Trade loan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
