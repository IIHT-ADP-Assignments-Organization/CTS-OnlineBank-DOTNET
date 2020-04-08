﻿using OnlineBank.BusinessLayer.Interfaces;
using OnlineBank.DataLayer.NHibernate;
using OnlineBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.BusinessLayer.Services
{
    public class CustomerServices : ICustomerService
    {
        private readonly IMapperSession _session;

        public CustomerServices(IMapperSession session)
        {
            _session = session;
        }

        public double CheckBalance(long accountNumber)
        {
            throw new NotImplementedException();
        }

        public OldCustomer GetOldCustomer(long accountNumber, string userName, string password)
        {
             OldCustomer oldCustomer = new OldCustomer();
            return oldCustomer;
        }


        public OldCustomer CloseAccount(long accountNumber, string userName, string password)
        {
            OldCustomer oldCustomer = new OldCustomer();
            return oldCustomer;
        }

        public int CreateAccount(Customer customer)
        {
            Customer customer1 = new Customer();
            var CutomerId = customer1.Id;
            return CutomerId;
        } 

        public bool Deposit(long accountNumber, string userName, double amount)
        {
            return false;
        }

        public bool FundTransfer(long accountNumber, long targetAccountNumber, double amount)
        {
            return false;
        }

        public bool Login(string userName, string password)
        {
            return false;
        }

        public bool Logout(string userName)
        {
            return false;
        }

        public double WithdrawAmount(long accountNumber, string userName, double amount)
        {
            throw new NotImplementedException();
        }
    }
}
