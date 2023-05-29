using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13.SwagLabs.PageObject
{
    internal class CartPage : BasePage
    {

        private By CheckoutButton = By.Id("checkout");
        private By RemoveBackPackButton = By.XPath("//*[@data-test='remove-sauce-labs-backpack']");
        private By RemoveSauceLabsBikeLighntButton = By.XPath("//*[@data-test='remove-sauce-labs-bike-light']");


        private By ErrorMessage = By.CssSelector(".error-message-container.error");
        private By LoginButton = By.CssSelector(".submit-button");

        public const string url = "https://www.saucedemo.com/cart.html";

        public const string STANDART_USER_NAME = "standard_user";
        public const string STANDART_USER_PASSWORD = "secret_sauce";

        public CartPage(WebDriver webDriver) : base(webDriver)
        {
        }

        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
