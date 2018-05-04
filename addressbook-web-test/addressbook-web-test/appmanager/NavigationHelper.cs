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
            driver.Navigate().GoToUrl("http://localhost/addressbook/group.php");
        }


        public void GoToGroupsPage()
        {
            //Перход на станицу со списком групп
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
