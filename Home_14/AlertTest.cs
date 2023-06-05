using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace Home_14
{
    [TestFixture]
    public class AlertTest :BaseTest
    {
        [Test]
        public void AcceptAlert()
        {
            Browser.Instance.NavigateToUrl("https://the-internet.herokuapp.com/context_menu");
            Actions action = new Actions(driver);
            

            Browser.Instance.ExecuteScript("arguments[0].click();", button);

            Browser.Instance.AcceptAllert();
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
