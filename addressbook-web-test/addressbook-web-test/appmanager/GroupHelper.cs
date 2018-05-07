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
    public class GroupHelper : HelperBase
    {


        public GroupHelper(IWebDriver driver) : base(driver)
        {

        }


        public void InitGroupGreation()
        {
            //Создание новой группы
            driver.FindElement(By.Name("new")).Click();
        }



        public void FillGroupForm(GroupData group)
        {
            ////Заполнение данными форму
            //By locator = By.Name("group_name");
            //string text = group.Name;
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);

            //driver.FindElement(By.Name("group_header")).Click();
            //driver.FindElement(By.Name("group_header")).Clear();
            //driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            //driver.FindElement(By.Name("group_footer")).Click();
            //driver.FindElement(By.Name("group_footer")).Clear();
            //driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        public void Type(By locator, string text)
        {   
            if(text != null)
            {
                driver.FindElement(locator).Click();
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            
            
        }

        public void SubmitGroupCreaton()
        {
            //Подтверждение
            driver.FindElement(By.Name("submit")).Click();
        }

        public void UpdateGroupCreaton()
        {
            //Подтверждение
            driver.FindElement(By.Name("update")).Click();
        }

        public void ReturnToGroupsPage()
        {
            //Возвращаемся на главную страницу
            driver.FindElement(By.LinkText("group page")).Click();
        }



        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }

        public void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }

        public void ModificationGroup()
        {
            driver.FindElement(By.Name("edit")).Click();
        }
    }//
}