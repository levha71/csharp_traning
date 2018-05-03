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
    public class GroupRemovalTests : TestBase
    {
        

        [Test]
        public void GroupRemovalTest()
        {
            GoToHomePage(); //Открытие главной страницы
            Login(new AccountData("admin","secret"));//Login Заполнение логина и пароля
            GoToGroupsPage();//Перход на станицу со списком групп
            SelectGroup(1);//Выделяем удаляемую группу
            RemoveGroup();//Удаляем группу
            ReturnToGroupsPage();//Возвращаемся на страницу групп
            ReturnHomePage();//Разлогиниваемся
        }       
    }
}
