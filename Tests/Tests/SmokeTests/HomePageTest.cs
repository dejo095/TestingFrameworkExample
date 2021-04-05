using NUnit.Framework;
using System;
using System.Collections;
using Tests.Base;
using Tests.Pages;

namespace Tests.Tests.SmokeTests
{
    [TestFixture]
    public class HomePageTest : TestBase
    {
        [Test, Order(2), Category("Smoke")]
        public void HomePage_SortingByPriceHighToLow_ShouldWork()
        {
            /*Assert.That(answer, Is.EqualTo(42), "Some useful error message");*/
            HomePage homePage = new HomePage(_driver);
            homePage.ChooseOptionByValue("hilo");

        }
    }
}
