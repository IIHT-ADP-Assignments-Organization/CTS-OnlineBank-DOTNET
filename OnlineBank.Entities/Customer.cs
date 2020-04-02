using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.Entities
{
   public class Customer
    {
        public long AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
        public string AccountType { get; set; }
        public string Password { get; set; }
    }
}
