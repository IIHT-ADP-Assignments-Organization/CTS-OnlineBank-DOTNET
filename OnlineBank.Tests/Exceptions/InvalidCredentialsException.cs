using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.Tests.Exceptions
{
  public  class InvalidCredentialsException :Exception
    {
        public string message = "Please enter valid usename & password";

        public InvalidCredentialsException()
        {

        }
        public InvalidCredentialsException(string messages)
        {
            message = messages;
        }
    }
}
