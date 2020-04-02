using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.Entities
{
   public class Transaction
    {
        public long TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public long AccountNumber { get; set; }
    }
}
