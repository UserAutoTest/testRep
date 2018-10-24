using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework;
using UIAnuitexAutoProject.Framework.HomePage;

namespace UIAnuitexAutoProject.Test
{
    public class CreateAccount : BaseTest
    {

        [Test]
        public void CreateNewAccount()
        {
            HomePage homePage = new HomePage(Driver);
            AllProductInCategoryPage televisionsVideoPage = new AllProductInCategoryPage(Driver);
            ProductDetailsPage productDetailsPage = new ProductDetailsPage(Driver);
            RightNavMenu rightNavMenu = new RightNavMenu(Driver);
            CreateYourAccount createYourAccount = new CreateYourAccount(Driver);
            ProfilePage profilePage = new ProfilePage(Driver);

            homePage
                .ClickAccountIcon();
            rightNavMenu
                .ClickCreateAccountLink();
            createYourAccount
                .FillInFirstNameField($"Test{DateTime.Now.ToString("yyyyMMddHHmmss")}")
                .FillInLastNameField($"Name{DateTime.Now.ToString("yyyyMMddHHmmss")}")
                .FillInEmailAddress($"test{DateTime.Now.ToString("yyyyMMddHHmmss")}@gmail.com")
                .FillInCreateAPassword("12345678")
                .ClickCreateAccountButton();
            profilePage
                .ClickAccountIconForSignInUser();

            Assert.AreEqual("TN", homePage.GetAcountIconValue(), "User is creadet successfuly");
        }
    }
}
