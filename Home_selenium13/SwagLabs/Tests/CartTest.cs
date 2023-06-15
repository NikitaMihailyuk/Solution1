using Home_selenium13.SwagLabs.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13.SwagLabs.Tests
{
    internal class CartTest : SwagLabBaseTest
    {

        [Test]

        public void CartTestReturn()
        {
            var inventoryPage = new LoginPage(driver).OpenPage().LoginAsStandartUser();
            var cartPage = new InventoryPage(driver).OpenPage().OpenCartPage();
            inventoryPage.OpenPage();
        }


        [Test]

        public void CartTestAddProduct()
        {
            var inventoryPage = new LoginPage(driver).OpenPage().LoginAsStandartUser();
            inventoryPage.AddProduct1();
            inventoryPage.AddProduct2();
            var cartPage = new InventoryPage(driver).OpenPage().OpenCartPage();
            Console.WriteLine(cartPage.CountProducts());
            Assert.That( cartPage.CountProducts(), Is.EqualTo(2)); 
        }

        [Test]
        public void CartTestRemoveProduct()
        {
            var inventoryPage = new LoginPage(driver).OpenPage().LoginAsStandartUser();
            inventoryPage.AddProduct1();
            inventoryPage.AddProduct2();
            var cartPage = new InventoryPage(driver).OpenPage().OpenCartPage();
            cartPage.RemoveProductBackPack();
            cartPage.RemoveProductBikeLight();
            Console.WriteLine(cartPage.CountProducts());

        }
    }
}
