using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class TestBase
    {
        //protected IWebDriver driver;
        //private StringBuilder verificationErrors;
        //protected string baseURL;

        //protected LoginHelper loginHelper;
        //protected NavigationHelper navigator;
        //protected GroupHelper groupHelper;

        public ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = TestSuiteFixture.app;
            //app = new ApplicationManager();
            
          //  app.Auth.Login(new AccountData("admin", "secret"));

         //   FirefoxOptions options = new FirefoxOptions();
         //   options.UseLegacyImplementation = true;
         //   options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
         //   driver = new FirefoxDriver(options);
         //   baseURL = "http://localhost";
         //   verificationErrors = new StringBuilder();

            //loginHelper = new LoginHelper(driver);
            //navigator = new NavigationHelper(driver);
            //groupHelper = new GroupHelper(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
           // app.Stop();
            //try
            //{
            //    driver.Quit();
            //}
            //catch (Exception)
            //{
            //    // Ignore errors if unable to close the browser
            //}
            //Assert.AreEqual("", verificationErrors.ToString());
        }


    }

}