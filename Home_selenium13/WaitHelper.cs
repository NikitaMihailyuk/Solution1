using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13
{
    internal class WaitHelper : BaseTest
    {

        protected void WaitElement(WebDriver driver, By by, int time=10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by));
        }
        protected void WaitElementWithTitle(WebDriver driver, By by, string text, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by).Text.ToLower() == text.ToLower());
        }
        protected void WaitElements(WebDriver driver, By by, int count, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by).Count == count);


    }
}
