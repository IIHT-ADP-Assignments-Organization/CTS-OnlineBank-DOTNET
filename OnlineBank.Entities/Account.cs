using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.Entities
{
   public class Account
    {
        public string AccountType { get; set; }
        public string Description { get; set; }
        public double MinBalance { get; set; }
    }
}
