using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = null;
            int attemp = 0;

            while (driver.FindElements(By.Id("test")).Count == 0 && attemp < 60) {
                System.Threading.Thread.Sleep(1000);
                attemp++;
            }
            // ....
        }
    }
}
