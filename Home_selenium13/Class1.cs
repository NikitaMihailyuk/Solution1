using Home_selenium13.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13
{
    internal class Class1 : BaseTest
    {
        internal class AdvanceTests : BaseTest
        {

            [Test]
            public void AcceptAlert()
            {
                Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/javascript_alerts");
                var button = Browser.Instance.Driver.FindElement(By.XPath("(//button)[1]"));

                Browser.Instance.ExecuteScript("arguments[0].click();", button);

                Browser.Instance.AcceptAllert();
            }


            [Test]
            public void Iframe()
            {
                Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/iframe");
                Browser.Instance.SwitchToFrame("mce_0_ifr");

                var text = Browser.Instance.Driver.FindElement(By.TagName("p")).Text;

                Browser.Instance.SwitchToDefault();

            }

            [Test]
            public void Upload()
            {
                var path = Environment.CurrentDirectory;
                var path2 = "/TestData/HomeWork14.jpg";
                var fullPath = Path.Combine(path, path2);


                Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/upload");
                Browser.Instance.Driver.FindElement(By.Id("file-upload")).SendKeys(DirectoryHelper.GetTestDataFolderPath() + "homework14.jpg"); ///
                var text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).Text;
                text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).GetAttribute("value");
            }

        }
    }
}
