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
            app.Navigator.GoToHomePage(); //Открытие главной страницы
            app.Auth.Login(new AccountData("admin", "secret"));//Login Заполнение логина и пароля
            app.Navigator.GoToGroupsPage();//Перход на станицу со списком групп
            app.Groups.SelectGroup(1);//Выделяем удаляемую группу
            app.Groups.RemoveGroup();//Удаляем группу
            app.Groups.ReturnToGroupsPage();//Возвращаемся на страницу групп
            app.Auth.ReturnHomePage();//Разлогиниваемся
        }
    }
}