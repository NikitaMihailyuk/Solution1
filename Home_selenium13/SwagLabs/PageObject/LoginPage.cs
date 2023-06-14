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
        private By ErrorMessage = By.CssSelector("");
        private By LoginButton = By.CssSelector("");

        public const string url = "https://www.saucedemo.com/";


        public LoginPage(WebDriver webDriver) : base(webDriver)
        {

        }
        public LoginAsUser()
        {
            driver.FindElement(UserNameInput).SendKeys("username");
            driver.FindElement(PasswordInput).SendKeys("Password");
            driver.FindElement(LoginButton).Click();

        }
    }


}
