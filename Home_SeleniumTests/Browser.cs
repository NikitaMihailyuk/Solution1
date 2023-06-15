using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_SeleniumTests
{
    public class Browser
    {
        private static Browser instanse = null;
        private IWebDriver driver;
        public IWebDriver Driver { get { return driver; } }

        public static Browser Instanse
        {
            get
            {
                if (instanse == null)
                {
                    instanse = new Browser();
                }
                return instanse;
            }
        }
        private Browser()
        {
            bool isHeadless = false;
            if (isHeadless)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                      driver = new ChromeDriver(options);
            }
            else
            {
                driver = new ChromeDriver();
            }
         
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
           // driver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
        }
        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
