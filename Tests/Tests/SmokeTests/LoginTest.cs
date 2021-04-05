using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Base;
using Tests.Pages;

namespace Tests.Tests.SmokeTests
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        private readonly string _url = "https://www.saucedemo.com/inventory.html";

        [Test, Order(0), Category("Smoke")]
        public void Login_InvalidCredentials_ShouldFail()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.LoginUser("ivek", "lapecki");

            Assert.AreNotEqual(_url, _driver.Url);
        }

        [Test, Order(1), Category("Smoke")]
        public void Login_ValidCredentials_ShouldSucceed()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.LoginUser("standard_user", "secret_sauce");

            Assert.AreEqual(_url, _driver.Url);
            /*Assert.That(_driver.Url, Is.EqualTo(_url));*/
        }
    }
}
