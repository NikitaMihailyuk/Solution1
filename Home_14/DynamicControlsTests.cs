using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Home_14.Core;

namespace Home_14
{
    public class  DynamicControlsTests : BaseTest
    {
        [Test]
        public void DynamicControlsTest()
        {
            var cartPage = new DynamicControlsPage(driver).OpenPage().OpenDynamicControlsPage();
            cartPage.ClickCheckbox();
    }
}
