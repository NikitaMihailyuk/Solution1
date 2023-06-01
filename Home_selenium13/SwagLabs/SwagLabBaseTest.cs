using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Home_selenium13.SwagLabs
{
    /*
     Основное задание:
Создать новый проект SauceDemo https://www.saucedemo.com/
Описать дополнительные страницы, используя Page Object Pattern (так же модели и возвращение самой страницы this  и создание новых страниц), CartPage и  CheckoutPage
Написать минимум 5 тестов для приложения и создать Pull Request

     */
    internal class SwagLabBaseTest :BaseTest
    {
        [SetUp]
        public void SetUp()
        {
          // driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}