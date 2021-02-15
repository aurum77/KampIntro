using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HouseLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("House loan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
