using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Tests.Base;

namespace Tests.Pages
{
    public class LoginPage
    {
        IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement _username => _driver.FindElement(By.Id("user-name"));
        IWebElement _password => _driver.FindElement(By.Id("password"));
        IWebElement _loginBtn => _driver.FindElement(By.Id("login-button"));

        public void LoginUser(string user, string pass)
        {
            _username.SendKeys(user);
            _password.SendKeys(pass);
            _loginBtn.Click();
        }
    }
}
