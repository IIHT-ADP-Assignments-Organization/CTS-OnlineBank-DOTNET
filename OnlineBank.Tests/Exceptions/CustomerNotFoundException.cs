using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.Tests.Exceptions
{ 
    class CustomerNotFoundException :Exception
    {
        public string message = "User is Not Found Please SignUp";

        public CustomerNotFoundException()
        {

        }
        public CustomerNotFoundException(string messages)
        {
            message = messages;
        }
    }
}
