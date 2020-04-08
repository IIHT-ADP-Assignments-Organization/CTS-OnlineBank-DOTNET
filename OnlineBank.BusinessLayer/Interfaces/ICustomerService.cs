using OnlineBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBank.BusinessLayer.Interfaces
{
    public interface ICustomerService
    {
        int CreateAccount(Customer customer);
        bool Login(string userName, string password);
        bool Deposit(long accountNumber, string userName, double amount);
        double CheckBalance(long accountNumber);
        double WithdrawAmount(long accountNumber, string userName, double amount);
        bool FundTransfer(long accountNumber, long targetAccountNumber, double amount);
        OldCustomer CloseAccount(long accountNumber, string userName, string password);
        bool Logout(string userName);
        OldCustomer GetOldCustomer(long accountNumber, string userName, string password);

    }
}
