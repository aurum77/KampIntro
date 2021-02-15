using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Interface names start with 'I' to increase visibility
    // When we want a function to do different things
    // according to the class we use the interface
    interface ILoanManager
    {
        void Calculate();
        void DoSomething();
    }
}
