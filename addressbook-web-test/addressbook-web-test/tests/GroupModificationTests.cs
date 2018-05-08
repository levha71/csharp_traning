using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

   public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            app.Navigator.GoToHomePage(); //Открытие главной страницы
            app.Auth.Login(new AccountData("admin", "secret"));//Login Заполнение логина и пароля
            app.Navigator.GoToGroupsPage();//Перход на станицу со списком групп

            List<GroupData> oldGroups = app.Groups.GetGroupList(); //Получение спика групп до создания новой группы

            app.Groups.SelectGroup(0);//Выделяем мщдифицируемую группу (в икспас запросе добавленна еденица)
            app.Groups.ModificationGroup();//переход на выделеную группу
            GroupData group = new GroupData("bbb"); //Заполнение данными формы
            group.Header = null;
            group.Footer = null;
            app.Groups.FillGroupForm(group);//Заполнение данными формы

            app.Groups.UpdateGroupCreaton();//Подтверждение
            app.Groups.ReturnToGroupsPage();//Возвращаемся на страницу групп

            List<GroupData> newGroups = app.Groups.GetGroupList();   //Получение спика групп после создания новой группы(GetGroupList Метод возвращающий список групп)
                                                                     //groups.Count; //Количество элементов в списке
            Assert.AreEqual(oldGroups.Count, newGroups.Count);  //Проверка что списки до создания нового и после создания равны
            //==================================
            oldGroups[0].Name = group.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            app.Auth.ReturnHomePage();//Разлогиниваемся
        }
    }
}
