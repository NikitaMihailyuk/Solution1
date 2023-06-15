using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13.SwagLabs.PageObject
{


    /*
     * 
     * Основное задание:
Создать новый проект SauceDemo https://www.saucedemo.com/
Описать дополнительные страницы, используя Page Object Pattern
    (так же модели и возвращение самой страницы this  и создание новых страниц),
    CartPage и  CheckoutPage
Написать минимум 5 тестов для приложения и создать Pull Request


    *Задачка по локаторам используется чтобы потом было проще писать тесты, 
    *можно  пропускать и использовать как полезные материалы *
Создать новый класс, в нем для ресурса https://www.saucedemo.com/  со
    ставить список локаторов, можно искать на ВСЕХ страницах приложения 
    (driver.findWebElement(<локатор>)) для КАЖДОГО из примеров локаторов ниже:
id    name  classname
tagname  linktext  partiallinktext
xpath
Поиск по атрибуту, например By.xpath("//tag[@attribute='value']");
Поиск по тексту, например By.xpath("//tag[text()='text']");
Поиск по частичному совпадению атрибута, например By.xpath("//tag[contains(@attribute,'text')]");
Поиск по частичному совпадению текста, например By.xpath("//tag[contains(text(),'text')]");
ancestor, например //*[text()='Enterprise Testing']//ancestor::div
descendant
following
parent
preceding
Подсказка:  https://www.w3schools.com/xml/xpath_axes.asp
*поиск элемента с условием AND, например //input[@class='_2zrpKA _1dBPDZ' and @type='text']
css
.class
.class1.class2
.class1 .class2
#id
tagname
tagname.class
 [attribute=value] [attribute~=value] [attribute|=value] [attribute^=value] [attribute$=value][attribute*=value]
     */

    internal class InventoryPage : BasePage
    {
        //public LeftMenu LeftMenu;
        private By ShoppingCartLink = By.ClassName("shopping_cart_link");
        private By Product1 = By.CssSelector("#add-to-cart-sauce-labs-backpack");
        private By AddBackPackButton = By.XPath("//*[@data-test='add-to-cart-sauce-labs-backpack']");
        private By AddSauceLabsBikeLighntButton = By.XPath("//*[@data-test='add-to-cart-sauce-labs-bike-light']");

        public const string url = "https://www.saucedemo.com/inventory.html";


        public InventoryPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitHelper.WaitElement(webDriver, ShoppingCartLink);
            // LeftMenu = new LefMenu(driver);
        }

        public override InventoryPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public CartPage OpenCartPage()
        {
            driver.FindElement(ShoppingCartLink).Click();
            return new CartPage(driver);
        }


        public void AddProduct1()
        {
            driver.FindElement(AddBackPackButton).Click();  
        }
        public void AddProduct2()
        {
            driver.FindElement(AddSauceLabsBikeLighntButton).Click();
        }
    }
}