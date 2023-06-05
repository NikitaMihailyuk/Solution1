using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Home_14
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
