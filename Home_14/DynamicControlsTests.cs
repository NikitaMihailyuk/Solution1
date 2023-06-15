using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Home_14
{
    public class DynamicControlsTests : BaseTest
    {
       
        [Test]
        public void DynamicControlsTest()
        {
            var cartPage = new DynamicControlsPage(driver).OpenPage();
            cartPage.ClickCheckbox();
            cartPage.RemmoveButton();
            string Text1 = cartPage.TextExpecter();
            Assert.That(Text1, Is.EqualTo("It's gone!"));
            try
            {
                cartPage.ClickCheckbox();
                cartPage.FieldInput();
            }
            catch (Exception ex)
            {}
            cartPage.InputButton();
            Text1 = cartPage.TextExpecter();
            Assert.That(Text1, Is.EqualTo("It's enabled!"));
            cartPage.FieldInput();

        }
    }
}
