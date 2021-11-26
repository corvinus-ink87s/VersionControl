using NUnit.Framework;
using System;
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
            Assert.AreEqual(result, expectedResult);
        }
    }
}
