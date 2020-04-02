using NSubstitute;
using OnlineBank.BusinessLayer.Interfaces;
using OnlineBank.BusinessLayer.Services;
using OnlineBank.DataLayer.NHibernate;
using OnlineBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace BusTicketReservationSystem.Tests.TestCases
{
    public class BounadryTests
    {
        private readonly ICustomerService _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public BounadryTests()
        {
            _service = new CustomerServices(_session);
        }


        [Fact]
        public void Boundary_Testfor_ValidEmail()
        {
            //Action
            var customer = new Customer()
            {
                AccountNumber = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName="Rose",
                Gender="Female",
                Address1 = "Bangalore",
                Address2 = "Bangalore",
                Mobile =9908765433,
                Email = "abc@gmail.com",
                Amount = 1000,
                Status ="active",
                AccountType = "SalaryAccount",
                Password = "12345678"
            };

            bool isEmail = Regex.IsMatch(customer.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public void Boundary_Testfor_ValidAmount()
        {
            //Action
            var customer = new Customer()
            {
                AccountNumber = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName="Rose",
                Gender="Female",
                Address1 = "Bangalore",
                Address2 = "Bangalore",
                Mobile =9908765433,
                Email = "abc@gmail.com",
                Amount = 1000,
                Status ="active",
                AccountType = "SalaryAccount",
                Password = "12345678"
                };

            //Assert
            Assert.NotInRange(customer.Amount,0,1000);
        }

        [Fact]
        public void Boundary_Testfor_ValidContactNumber()
        {
            //Action
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

            //Assert
            Assert.Equal(10, customer.Mobile.ToString().Length);
        }

        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
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
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = customer.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
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
            var MinLength = 2;
            var MaxLength = 50;

            //Action
            var actualLength = customer.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
      
}