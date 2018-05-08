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
            app.Groups.SelectGroup(0);//Выделяем мщдифицируемую группу (в икспас запросе добавленна еденица)
            app.Groups.ModificationGroup();//переход на выделеную группу
            GroupData group = new GroupData("bbb"); //Заполнение данными формы
            group.Header = null;
            group.Footer = null;
            app.Groups.FillGroupForm(group);//Заполнение данными формы

            app.Groups.UpdateGroupCreaton();//Подтверждение
            app.Groups.ReturnToGroupsPage();//Возвращаемся на страницу групп
            app.Auth.ReturnHomePage();//Разлогиниваемся
        }
    }
}
