using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_12_selenium
{
    internal class InputTests : BaseTest
    {
        [Test]
        public void EnterNumbers()
        {

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("input"));

            input.SendKeys("100");
            input.Clear();
            input.SendKeys("48");
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);

            var text = input.GetAttribute("value");

        }
    }
}
