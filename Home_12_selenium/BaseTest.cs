using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Home_12_selenium
{
    public class BaseTest
    {
        protected WebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // var driver = new ChromeDriver(@"C:\webdriver");
            // WebDriver ie = new InternetExplorerDriver();
            driver = new ChromeDriver();
            Actions action = new Actions(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit(); // сессия
        }
    }
}