﻿using Moq;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;


namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd", "false"),
            TestCase("abcd@xyz.com", "true")
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // arrange
            var accountController = new AccountController();

            // act
            var result = accountController.ValidateEmail(email);

            // assert
            Assert.AreEqual(result, expectedResult);
        }


        [
            Test,
            TestCase("asdfg123", "false"),
            TestCase("ASDF234", "false"),
            TestCase("ASDFGasdf", "false"),
            TestCase("asdfgSDF123", "true"),
        ]

        public void TestValidatePassword(string password, bool expectedResult)
        {
            // arrange
            var accountController = new AccountController();

            // act
            var result = accountController.ValidatePassword(password);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [
            Test,
            TestCase("irf@uni-corvinus.hu", "Abcd1234"),
            TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            // arrange
            var accounManagerMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountManagersMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()));
                .Returns<Account>(a => a);
            var accountController = new AccountController();
            accountController.AccountManager = accounManagerMock.Object;

            //act
            var result = accountController.Register(email, password);
           // accountController.AccountManager.Accounts.Contains(result);

            //assert
            Assert.AreEqual(email, result.Email);
            Assert.AreEqual(password, result.Password);
            Assert.AreEqual(Guid.Empty, result.ID);
            accounManagerMock.Verify(m => m.CreateAccount(result), Times.Once);
        }

        private void Returns<T>(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        [
            Test,
            TestCase("irf@uni-corvinus", "Abcd1234"),
            TestCase("irf.uni-corvinus.hu", "Abcd1234"),
            TestCase("irf@uni-corvinus.hu", "abcd1234"),
            TestCase("irf@uni-corvinus.hu", "ABCD1234"),
            TestCase("irf@uni-corvinus.hu", "abcdABCD"),
            TestCase("irf@uni-corvinus.hu", "Ab1234"),
        ]
        public void TestRegisterValidationException(string email, string password)
        {
            // arrange
            var accountController = new AccountController();

            //act
            try
            {
                accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {

                Assert.IsInstanceOf<ValidationException>(ex);
            }

            
        }

    }
}
