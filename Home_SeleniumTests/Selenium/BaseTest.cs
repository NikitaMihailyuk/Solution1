using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Home_SeleniumTests.Selenium
{
    public class BaseTest
    {
        protected IWebDriver driver = Browser.Instanse.Driver;

        [SetUp]
        public void SetUp()
        {
            // var driver = new ChromeDriver(@"C:\webdriver");
            // WebDriver ie = new InternetExplorerDriver();
           /// driver = new ChromeDriver();
          ///  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
           Browser.Instanse.Driver.Close();
        }
    }
}