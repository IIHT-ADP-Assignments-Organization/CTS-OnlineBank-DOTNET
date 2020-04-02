using FluentNHibernate.Mapping;
using OnlineBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.DataLayer.Mapping
{
    public class CustomerMapping : ClassMap<Customer>
    {
        public CustomerMapping()
        {
            Id(x => x.AccountNumber);

            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.UserName);
            Map(x => x.Gender);
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.Mobile);
            Map(x => x.Email);
            Map(x => x.Amount);
            Map(x => x.Balance);
            Map(x => x.Status);
            Map(x => x.AccountType);
            Map(x => x.Password);
            
            Table("Customer");
        }
    }
}
    
