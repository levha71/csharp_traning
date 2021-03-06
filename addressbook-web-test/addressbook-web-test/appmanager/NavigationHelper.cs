﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {


        public NavigationHelper(IWebDriver driver) : base(driver)
        {

        }

        public void GoToHomePage()
        {
            if (driver.Url == "http://localhost/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
          //  driver.Navigate().GoToUrl(baseURL + "/addressbook/group.php");
        }


        public void GoToGroupsPage()
        {
            if(driver.Url == "http://localhost/addressbook/group.php" 
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            //Перход на станицу со списком групп
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}