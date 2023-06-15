using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Home_14.Pages;


namespace Home_14
{
    public class AlertTest :BaseTest
    {
        [Test]
        public void AcceptAlert()
        {
            Actions action = new Actions(driver);
            var alertPage = new AlertPage(driver).OpenPage();
     
            alertPage.OpenContext();
            var text = alertPage.AlertText();
            Assert.That(text, Is.EqualTo("You selected a context menu"));
            Browser.Instance.AcceptAllert();
        ///   Browser.Instance.ExecuteScript("arguments[0].click();",button);
        }


        [Test]
        public void Iframe()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/iframe");
            Browser.Instance.SwitchToFrame("mce_0_ifr");

            var text = Browser.Instance.Driver.FindElement(By.TagName("p")).Text;

            Browser.Instance.SwitchToDefault();

        }



    }
}
