using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        private static ApplicationManager instance;

        public ApplicationManager()
        {
            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver);//baseURL
            groupHelper = new GroupHelper(driver);

            FirefoxOptions options = new FirefoxOptions();
            options.UseLegacyImplementation = true;
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
            verificationErrors = new StringBuilder();
            baseURL = "http://localhost";

            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver);
            groupHelper = new GroupHelper(driver);
        }

        //public static ApplicationManager GetInstance()
        //{
        //    if(instance == null)
        //    {
        //        instance = new ApplicationManager();
        //    }
        //    return instance;
        //}

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }
    }
}