using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
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

            List<GroupData> oldGroups = app.Groups.GetGroupList(); //Получение спика групп до создания новой группы

            app.Groups.InitGroupGreation();//Создание новой группы
            GroupData group = new GroupData("aaa"); //Заполнение данными формы
            group.Header = "ddd";
            group.Footer = "fff";
            app.Groups.FillGroupForm(group);//Заполнение данными формы
            app.Groups.SubmitGroupCreaton();//Подтверждение
            app.Groups.ReturnToGroupsPage();//Возвращаемся на страницу групп
            

            List<GroupData> newGroups = app.Groups.GetGroupList();   //Получение спика групп после создания новой группы(GetGroupList Метод возвращающий список групп)
                                                                     //groups.Count; //Количество элементов в списке
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);  //Проверка что списки до создания нового и после создания имеют разницу в 1


            app.Auth.ReturnHomePage();//Разлогиниваемся
        }


    }
}