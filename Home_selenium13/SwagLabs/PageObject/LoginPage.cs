using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13.SwagLabs.PageObject
{
    internal class LoginPage : BasePage
    {
        private By UserNameInput = By.Id("user-name");
        private By PasswordInput = By.XPath("//*[@data-test='password']");
        private By ErrorMessage = By.CssSelector(".error-message-container.error");
        private By LoginButton = By.CssSelector(".submit-button");
        private By BasketCounter = By.CssSelector("#shopping_cart_container");

        public const string url = "https://www.saucedemo.com/";

        public const string STANDART_USER_NAME = "standard_user";
        public const string STANDART_USER_PASSWORD = "secret_sauce";

        public LoginPage(IWebDriver webDriver) : base(webDriver) { }

        public override LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public InventoryPage LoginAsStandartUser()
        {
            var user = new UserModel()
            {
                Name = STANDART_USER_NAME,
                Password = STANDART_USER_PASSWORD,
            };
            TryToLogin(user);
            return new InventoryPage(driver);
        }

        public void TryToLogin(UserModel user)
        {
            driver.FindElement(UserNameInput).SendKeys(user.Name);
            driver.FindElement(PasswordInput).SendKeys(user.Password);
            driver.FindElement(LoginButton).Click();
        }

        internal bool VerifyErrorMessage()
        {
            //check display status for ErrorMessage 
            return false;
        }
    }
}