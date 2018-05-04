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
    public class GroupGreationTests : TestBase
    {


        [Test]
        public void GroupGreationTest()
        {
            navigator.GoToHomePage(); //Открытие главной страницы
            loginHelper.Login(new AccountData("admin", "secret")); //Login Заполнение логина и пароля
            navigator.GoToGroupsPage(); //Перход на станицу со списком групп
            groupHelper.InitGroupGreation();//Создание новой группы
            GroupData group = new GroupData("aaa"); //Заполнение данными формы
            group.Header = "ddd";
            group.Footer = "fff";
            groupHelper.FillGroupForm(group);//Заполнение данными формы
            groupHelper.SubmitGroupCreaton();//Подтверждение
            groupHelper.ReturnToGroupsPage();//Возвращаемся на страницу групп
            loginHelper.ReturnHomePage();//Разлогиниваемся
        }


    }
}