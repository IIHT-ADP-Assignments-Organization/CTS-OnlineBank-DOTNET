using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.Tests.Exceptions
{ 
  public  class CustomerAlreadyExistException :Exception
    {
        public string message = "Already have an Account please login";

        public CustomerAlreadyExistException()
        {

        }
        public CustomerAlreadyExistException(string messages)
        {
            message = messages;
        }
    }
}
