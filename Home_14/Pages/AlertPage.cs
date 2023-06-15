using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Home_14.Pages
{
    internal class AlertPage : BasePage
    {
      
        private By AlertZone = By.Id("hot-spot");
        private By Text = By.Id("//*[@id='content']/script");

        public const string url = "https://the-internet.herokuapp.com/context_menu";


        public AlertPage(IWebDriver webriwer) : base(webriwer) { }
        public override AlertPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }
        public void OpenContext()
        {
            Actions action = new Actions(driver);
            action.ContextClick(driver.FindElement(AlertZone)).Perform();
        }
        public string AlertText()
        {
          IAlert alert = driver.SwitchTo().Alert();
          return alert.Text ;
        }

    }
}