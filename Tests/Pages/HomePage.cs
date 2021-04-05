using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Pages
{
    public class HomePage
    {
        IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Sort Select dropdown
        IWebElement _sortSelectElement => _driver.FindElement(By.ClassName("product_sort_container"));
        SelectElement _optionElement => new SelectElement(_sortSelectElement);

        public void ChooseOptionByValue(string value)
        {
            _optionElement.SelectByValue(value);
        }

    }
}
