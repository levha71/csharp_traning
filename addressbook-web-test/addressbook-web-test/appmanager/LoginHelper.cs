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

    public class LoginHelper : HelperBase
    {


        public LoginHelper(IWebDriver driver) : base(driver)
        {

        }

        public void Login(AccountData account)
        {
            //Login Заполнение логина и пароля.
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);

            //driver.FindElement(By.Name("user")).Click();
            //driver.FindElement(By.Name("user")).Clear();
            //driver.FindElement(By.Name("user")).SendKeys(account.Username);

            //driver.FindElement(By.Name("pass")).Click();
            //driver.FindElement(By.Name("pass")).Clear();
            //driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        public void ReturnHomePage()
        {
            //Разлогиниваемся
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}