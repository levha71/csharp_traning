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
            GoToHomePage(); //Открытие главной страницы
            Login(new AccountData("admin", "secret")); //Login Заполнение логина и пароля
            GoToGroupsPage(); //Перход на станицу со списком групп
            InitGroupGreation();//Создание новой группы
            GroupData group = new GroupData("aaa"); //Заполнение данными формы
            group.Header = "ddd";
            group.Footer = "fff";
            FillGroupForm(group);//Заполнение данными формы
            SubmitGroupCreaton();//Подтверждение
            ReturnToGroupsPage();//Возвращаемся на страницу групп
            ReturnHomePage();//Разлогиниваемся
        }

        
}
}
