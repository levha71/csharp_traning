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
            app.Navigator.GoToHomePage(); //Открытие главной страницы
            app.Auth.Login(new AccountData("admin", "secret")); //Login Заполнение логина и пароля
            app.Navigator.GoToGroupsPage(); //Перход на станицу со списком групп
            app.Groups.InitGroupGreation();//Создание новой группы
            GroupData group = new GroupData("aaa"); //Заполнение данными формы
            group.Header = "ddd";
            group.Footer = "fff";
            app.Groups.FillGroupForm(group);//Заполнение данными формы
            app.Groups.SubmitGroupCreaton();//Подтверждение
            app.Groups.ReturnToGroupsPage();//Возвращаемся на страницу групп
            app.Auth.ReturnHomePage();//Разлогиниваемся
        }

        
}
}
