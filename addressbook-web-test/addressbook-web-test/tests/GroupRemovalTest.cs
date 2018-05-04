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
            navigator.GoToHomePage(); //Открытие главной страницы
            loginHelper.Login(new AccountData("admin", "secret"));//Login Заполнение логина и пароля
            navigator.GoToGroupsPage();//Перход на станицу со списком групп
            groupHelper.SelectGroup(1);//Выделяем удаляемую группу
            groupHelper.RemoveGroup();//Удаляем группу
            groupHelper.ReturnToGroupsPage();//Возвращаемся на страницу групп
            loginHelper.ReturnHomePage();//Разлогиниваемся
        }
    }
}