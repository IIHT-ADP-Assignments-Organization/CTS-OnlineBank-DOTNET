using NSubstitute;
using OnlineBank.BusinessLayer.Interfaces;
using OnlineBank.BusinessLayer.Services;
using OnlineBank.DataLayer.NHibernate;
using OnlineBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusTicketReservationSystem.Tests.TestCases
{
  public  class FunctionalTests
    {
        private readonly ICustomerService _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTests()
        {
            _service = new CustomerServices(_session);
        }

        [Fact]
        public void Test_For_Valid_CreateAccount()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Gender = "Female",
                Address1 = "Bangalore",
                Address2 = "Bangalore",
                Mobile = 9908765433,
                Email = "abc@gmail.com",
                Amount = 1000,
                Status = "active",
                AccountType = "SalaryAccount",
                Password = "12345678"
            };
            //Action
            var IsRegistered = _service.CreateAccount(customer);
            //Assert
            Assert.True(IsRegistered);
        }

        [Fact]
        public void Test_For_Valid_Login()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Gender = "Female",
                Address1 = "Bangalore",
                Address2 = "Bangalore",
                Mobile = 9908765433,
                Email = "abc@gmail.com",
                Amount = 1000,
                Status = "active",
                AccountType = "SalaryAccount",
                Password = "12345678"
            };
            //Action
            var IsLogged = _service.Login(customer.UserName, customer.Password);
            //Assert
            Assert.True(IsLogged);
        }

        [Fact]
        public void Test_For_Valid_Deposit()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                UserName = "Rose",
                Amount = 1000,
            };
            //Action
            var IsDepositted = _service.Deposit(customer.AccountNumber, customer.UserName, customer.Amount);
            //Assert
            Assert.True(IsDepositted);
        }

        [Fact]
        public void Test_For_Valid_CheckBalance()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                UserName = "Rose",
                Amount = 1000,
            };
            //Action
            var amount = _service.CheckBalance(customer.AccountNumber);
            //Assert
            Assert.NotNull(amount.ToString());
        }

        [Fact]
        public void Test_For_Valid_WithdrawAmount()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                UserName = "Rose",
                Amount = 500,
            };

            //Action
            var beforWithdraw = _service.CheckBalance(customer.AccountNumber);
            var debitedAmount = _service.WithdrawAmount(customer.AccountNumber, customer.UserName, customer.Amount);
            var afterWithdraw= _service.CheckBalance(customer.AccountNumber);
            var Expected = beforWithdraw - afterWithdraw;
            //Assert
            Assert.Equal(Expected, debitedAmount);
        }

        [Fact]
        public void Test_For_Valid_FundTransfer()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                UserName = "Rose",
                Amount = 500,
            };
            var targetCustomer = new Customer()
            {
                AccountNumber = 1236,
                UserName = "Rosa",
                Amount = 500,
            };
       
            //Action
            var IsAdded = _service.FundTransfer(customer.AccountNumber, targetCustomer.AccountNumber, customer.Amount);
            //Assert
            Assert.True(IsAdded);
        }

        [Fact]
        public void Test_For_Valid_CloseAccount()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Gender = "Female",
                Address1 = "Bangalore",
                Address2 = "Bangalore",
                Mobile = 9908765433,
                Email = "abc@gmail.com",
                Amount = 1000,
                Status = "active",
                AccountType = "SalaryAccount",
                Password = "12345678"
            };
           
            //Action
            var IsBooked = _service.CloseAccount(customer.AccountNumber,customer.UserName, customer.Password);
            //Assert
            Assert.True(IsBooked);
        }

        [Fact]
        public void Test_For_Valid_Logout()
        {
            //Arrange
            var customer = new Customer()
            {
                AccountNumber = 1234,
                UserName = "Rosa",
                Amount = 500,
            };
            //Action
            var IsLoggedOut = _service.Logout(customer.UserName);
            //Assert
            Assert.True(IsLoggedOut);
        }

    }
}
