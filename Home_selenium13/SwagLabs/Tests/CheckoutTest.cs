using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_selenium13.Core;
using Home_selenium13.SwagLabs.PageObject;

namespace Home_selenium13.SwagLabs.Tests
{
    internal class CheckoutTest : SwagLabBaseTest
    {
        [Test]
        public void CartTestCheckout()
        {
            var inventoryPage = new LoginPage(driver).OpenPage().LoginAsStandartUser();
            inventoryPage.AddProduct1();
            inventoryPage.AddProduct2();
            var cartPage = new InventoryPage(driver).OpenPage().OpenCartPage();
            var checkoutPage = new CartPage(driver).OpenPage().OpenCheckOutPage();
            checkoutPage.InputData();
            checkoutPage.Continue();
        }
        [Test]
        public void CartTestCancel()
        {
            var inventoryPage = new LoginPage(driver).OpenPage().LoginAsStandartUser();
            var cartPage = new InventoryPage(driver).OpenPage().OpenCartPage();
            var checkoutPage = new CartPage(driver).OpenPage().OpenCheckOutPage();

            checkoutPage.InputData();
            checkoutPage.Cancel();
        }
    }
}
