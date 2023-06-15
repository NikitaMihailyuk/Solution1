using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_14
{
    internal class DynamicControlsPage : BasePage
    {

        private By Checkbox = By.CssSelector("input[type='checkbox']");
        private By RemoveButton = By.CssSelector("button[type ='button']");
        private By EnableDisableButton = By.CssSelector("button[onclick ='swapInput()']");
        private By Text = By.XPath("//*[@id='message']");
        private By InputTextField = By.CssSelector("input[type ='text']");


        public const string url = "https://the-internet.herokuapp.com/dynamic_controls";


        public DynamicControlsPage(IWebDriver webriwer) : base(webriwer) { }
        public override DynamicControlsPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public void ClickCheckbox()
        { 
            driver.FindElement(Checkbox).Click();
        }
        public void RemmoveButton()
        {
            driver.FindElement(RemoveButton).Click();
        }

        public string TextExpecter()
        {
            TimeSpan.FromSeconds(5);
            var text= driver.FindElement(Text).Text.ToString() ;
            return text; 
        }

        public void InputButton()
        {
            driver.FindElement(EnableDisableButton).Click();
        }

        public void FieldInput()
        {
            driver.FindElement(InputTextField).SendKeys("Hello field");
        }


        ///  public DynamicControlsPage OpenDynamicControlsPage()
       ///  {
         ///   driver.FindElement(CheckoutButton).Click();
         ///   return new DynamicControlsPage(driver);
       //  }   
    }
}
