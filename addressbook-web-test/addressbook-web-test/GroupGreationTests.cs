using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupGreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

    [SetUp]
    public void SetupTest()
    {
        FirefoxOptions options = new FirefoxOptions();
        options.UseLegacyImplementation = true;
        options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
        driver = new FirefoxDriver(options);
        verificationErrors = new StringBuilder();
    }

    [TearDown]
    public void TeardownTest()
    {
        try
        {
            driver.Quit();
        }
        catch (Exception)
        {
            // Ignore errors if unable to close the browser
        }
        Assert.AreEqual("", verificationErrors.ToString());
    }

    [Test]
    public void GroupGreationTest()
        {
            OpenHomePage(); //Открытие главной страницы
            Login("admin", "secret"); //Login Заполнение логина и пароля
            GoToGroupsPage(); //Перход на станицу со списком групп
            InitGroupGreation();//Создание новой группы
            FillGroupForm("aaa", "sss", "ddd");//Заполнение данными форму
            SubmitGroupCreaton();//Подтверждение
            ReturnToGroupsPage();//Возвращаемся на главную страницу
            ReturnHomePage();//Разлогиниваемся
        }

        private void ReturnHomePage()
        {
            //Разлогиниваемся
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private void ReturnToGroupsPage()
        {
            //Возвращаемся на главную страницу
            driver.FindElement(By.LinkText("group page")).Click();
        }

        private void SubmitGroupCreaton()
        {
            //Подтверждение
            driver.FindElement(By.Name("submit")).Click();
        }

        private void FillGroupForm(string name, string header, string footer)
        {
            //Заполнение данными форму
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(footer);
        }

        private void InitGroupGreation()
        {
            //Создание новой группы
            driver.FindElement(By.Name("new")).Click();
        }

        private void GoToGroupsPage()
        {
            //Перход на станицу со списком групп
            driver.FindElement(By.LinkText("groups")).Click();
        }

        private void Login(string username, string password)
        {
            //Login Заполнение логина и пароля.
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(username);
            driver.FindElement(By.Name("pass")).Click();
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }


        private void OpenHomePage()
        {
            //Открытие главной страницы
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }

        private bool IsElementPresent(By by)
    {
        try
        {
            driver.FindElement(by);
            return true;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    private bool IsAlertPresent()
    {
        try
        {
            driver.SwitchTo().Alert();
            return true;
        }
        catch (NoAlertPresentException)
        {
            return false;
        }
    }

    private string CloseAlertAndGetItsText()
    {
        try
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            if (acceptNextAlert)
            {
                alert.Accept();
            }
            else
            {
                alert.Dismiss();
            }
            return alertText;
        }
        finally
        {
            acceptNextAlert = true;
        }
    }
}
}
