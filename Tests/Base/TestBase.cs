using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Base
{
    public class TestBase
    {
        protected IWebDriver _driver = new ChromeDriver();

        [OneTimeSetUp]
        public void Open()
        {
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://www.saucedemo.com/";
        }

        [OneTimeTearDown]
        public void Close()
        {
            _driver.Quit();
        }
    }
}
