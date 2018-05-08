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
    public class GroupRemovalTests : TestBase
    {


        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.GoToHomePage(); //Открытие главной страницы
            app.Auth.Login(new AccountData("admin", "secret"));//Login Заполнение логина и пароля
            app.Navigator.GoToGroupsPage();//Перход на станицу со списком групп

            List<GroupData> oldGroups = app.Groups.GetGroupList(); //Получение спика групп до создания новой группы

            app.Groups.SelectGroup(0);//Выделяем удаляемую группу (в икспас запросе добавленна еденица)
            app.Groups.RemoveGroup();//Удаляем группу
            app.Groups.ReturnToGroupsPage();//Возвращаемся на страницу групп

            List<GroupData> newGroups = app.Groups.GetGroupList();   //Получение спика групп после создания новой группы(GetGroupList Метод возвращающий список групп)
          //  Assert.AreEqual(oldGroups.Count - 1, newGroups.Count);  //Проверка что списки до создания нового и после создания имеют разницу в 1

            oldGroups.RemoveAt(0); // Удаляем первый элемент в списке
            Assert.AreEqual(oldGroups, newGroups);// Сравниваем не размеры а сами списки


            app.Auth.ReturnHomePage();//Разлогиниваемся
        }
    }
}