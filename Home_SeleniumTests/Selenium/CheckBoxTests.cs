﻿using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Home_SeleniumTests.Selenium
{
    internal class CheckBoxTests : BaseTest
    {
        [Test]
        public void CheckBoxes()
        {
            
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

                driver.FindElement(By.LinkText("Checkboxes")).Click();


                List<IWebElement> checkBoxes = driver.FindElements(By.TagName("input")).ToList();
                Assert.IsNotEmpty(checkBoxes);

                var checkBoxOne = checkBoxes[0];
                var checkBoxSecond = checkBoxes[1];

            SetCheckBoxState(checkBoxOne, false);
            SetCheckBoxState(checkBoxOne, true);
            SetCheckBoxState(checkBoxOne, true);
            SetCheckBoxState(checkBoxOne, false);

            checkBoxSecond.Click();
                var selected = checkBoxSecond.Selected;
                var selectedByAttribute = checkBoxSecond.GetAttribute("checked");

        }

        public void  SetCheckBoxState(IWebElement element, bool flag)
       {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            if (selected || selectedByAttribute != flag)
            {
                element.Click();
            }


        }
            
       
    }
}
