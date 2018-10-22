using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework.HomePage;

namespace UIAnuitexAutoProject.Test
{
    public class FirstTest : BaseTest
    {
        [Test]
        public void First()
        {
            HomePage homePage = new HomePage(Driver);

            homePage
                .ClickMenuButton()
                .GetAllCategoryList();
        }
    }
}
