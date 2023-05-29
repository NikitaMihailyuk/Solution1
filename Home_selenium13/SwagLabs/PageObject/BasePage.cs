using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Home_selenium13.SwagLabs.PageObject
{
    internal abstract class BasePage
    {
        protected WebDriver driver;

        public BasePage(WebDriver webDriver)
        {
            driver = webDriver;
        }

        public abstract void OpenPage();
    }
}
