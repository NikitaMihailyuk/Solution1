using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Home_SeleniumTests.Selenium
{
    internal class DropDownTests : BaseTest
    {
        
        [Test]
        public void AddRemoveButton()
        {
            {
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

                driver.FindElement(By.LinkText("Dropdown")).Click();

                SelectElement select = new(driver.FindElement(By.Id("dropdown")));
                select.SelectByIndex(2);
                select.DeselectByText("Please select an option");
            }
        }
    }
}
