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
            accountController.ValidateEmail(email);

            // assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
