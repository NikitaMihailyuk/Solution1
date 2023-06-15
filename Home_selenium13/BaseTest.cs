using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_selenium13.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Home_selenium13
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver = Browser.Instance.Driver;

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
          //  driver.Quit(); // сессия
        }
    }
}
