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
            var page = new LoginPage(driver);
            page.OpenPage();
            page.LoginAsStandartUser();

        }
    }
}
