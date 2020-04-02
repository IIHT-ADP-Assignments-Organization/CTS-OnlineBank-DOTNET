using NSubstitute;
using OnlineBank.BusinessLayer.Interfaces;
using OnlineBank.BusinessLayer.Services;
using OnlineBank.DataLayer.NHibernate;
using OnlineBank.Entities;
using OnlineBank.Tests.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusTicketReservationSystem.Tests.TestCases
{
   public class ExceptionTests
    {
        private readonly ICustomerService _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTests()
        {
            _service = new CustomerServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_CustomerNotFound()
        {
            
            //Assert
            var ex = Assert.Throws<CustomerNotFoundException>(() => _service.Login("ABC","123456"));
            Assert.Equal("User is Not Found Please SignUp", ex.message);
        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
           
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.Login("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.message);
        }
        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.Login("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.message);
        }

        [Fact]
        public void ExceptionTestFor_ValidRegistration()
        {
            var customer = new Customer()
            {
                AccountNumber = 12346,
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
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.CreateAccount(customer));
            Assert.Equal("Already have an Account please login", ex.message);
        }

    }
}
