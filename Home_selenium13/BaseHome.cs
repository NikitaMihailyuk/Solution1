using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Home_selenium13
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // var driver = new ChromeDriver(@"C:\webdriver");
            // WebDriver ie = new InternetExplorerDriver();
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit(); // сессия
        }
    }
}
