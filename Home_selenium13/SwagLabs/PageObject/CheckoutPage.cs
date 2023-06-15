using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13.SwagLabs.PageObject
{
    internal class CheckoutPage : BasePage
    {
        private By FirstName = By.CssSelector("#first-name");
        private By LastName = By.CssSelector("#last-name");
        private By PostalCode = By.CssSelector("#postal-code");
        private By CancelButton = By.XPath("//*[@id='cancel']");
        private By ContinueButton = By.CssSelector(".submit-button.btn");


        public const string url = "https://www.saucedemo.com/checkout-step-one.html";
        public CheckoutPage(IWebDriver webriwer) : base(webriwer) { }

        public override CheckoutPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public void InputData()
        {
            driver.FindElement(FirstName).SendKeys("This Is FirstName");
            driver.FindElement(LastName).SendKeys("This Is LastName");
            driver.FindElement(PostalCode).SendKeys("This Is Postalcode12345");
        }
        public void Cancel()
        {
            driver.FindElement(CancelButton).Click();
        }
        public void Continue()
        {
            driver.FindElement(ContinueButton).Click();
        }
    }
}
