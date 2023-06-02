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
        private By RemoveBackPackButton = By.XPath("//*[@data-test='remove-sauce-labs-backpack']");
        private By RemoveSauceLabsBikeLighntButton = By.XPath("//*[@data-test='remove-sauce-labs-bike-light']");
        private By FirstItemPrice = By.XPath("[@class='inventory_item_price'][0]");
        private By SecondItemPrice = By.XPath("[@class='inventory_item_price'][1]");
        private By ContinueShoppingButton = By.CssSelector("#continue-shopping");
        private By CheckoutButton = By.CssSelector(".btn.checkout_button");
        private By CounterProducts = By.XPath("//*[@id='shopping_cart_container']/a/span");

        public const string url = "https://www.saucedemo.com/cart.html";


        public CartPage(IWebDriver webriwer) : base(webriwer) { }
        public override CartPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public CheckoutPage OpenCheckOutPage()
        {
            driver.FindElement(CheckoutButton).Click();
            return new CheckoutPage(driver);
        }
        public InventoryPage ContinueShoppingPage()
        {
            driver.FindElement(ContinueShoppingButton).Click();
            return new InventoryPage(driver);
        }
        public void RemoveProductBackPack()
        {
            driver.FindElement(RemoveBackPackButton).Click();
        }
        public void RemoveProductBikeLight()
        {
            driver.FindElement(RemoveSauceLabsBikeLighntButton).Click();
        }
        public int CountProducts()
        {
            var count = driver.FindElement(CounterProducts).Text;
            return Int32.Parse(count);
        }
    }
}
