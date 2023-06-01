using Home_selenium13.Core;
using Home_selenium13.SwagLabs.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13.SwagLabs
{
    internal class LoginTest : SwagLabBaseTest
    {

        [Test]
        public void Login_StandartUser()
        {

       ///     Browser.Instance.NavigateToUrl("https://www.saucedemo.com/");

            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser();
        }

        [Test]
        public void Login()
        {
            var user = new UserModel()
            {
                Password = "asdasdasd",
                Name = "Test",
            };

            var page = new LoginPage(driver);

            page.OpenPage().TryToLogin(user);

            page.VerifyErrorMessage();
        }
    }
}

