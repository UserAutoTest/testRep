using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework;
using UIAnuitexAutoProject.Framework.HomePage;
using UIAnuitexAutoProject.Framework.Models;

namespace UIAnuitexAutoProject.Test
{
    public class CreateEditAccount : BaseTest
    {

        [Test]
        public void CreateNewAccount()
        {
            HomePage homePage = new HomePage(Driver);
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


        [Test]
        public void EditAccount()
        {
            HomePage homePage = new HomePage(Driver);            
            RightNavMenu rightNavMenu = new RightNavMenu(Driver);
            CreateYourAccount createYourAccount = new CreateYourAccount(Driver);
            ProfilePage profilePage = new ProfilePage(Driver);
            JsonConverter jsonConverter = new JsonConverter();
            UserFromJson user = jsonConverter.GetUser();            
            SignInPage signInPage = new SignInPage(Driver);

            homePage
                .ClickAccountIcon();
            rightNavMenu
                .ClickSignInLink();
            signInPage
                .FillInEmailAddressInput(user)
                .FillInPasswordInput(user)
                .ClickSignInButton();
            profilePage
                .ClickAccountIconForSignInUser();

            Assert.AreEqual("TN", homePage.GetAcountIconValue(), "User is creadet successfuly");
            }

        [Test]
        public void AddProductInCartLoggedInUser()
        {
            HomePage homePage = new HomePage(Driver);
            RightNavMenu rightNavMenu = new RightNavMenu(Driver);
            CreateYourAccount createYourAccount = new CreateYourAccount(Driver);
            ProfilePage profilePage = new ProfilePage(Driver);
            JsonConverter jsonConverter = new JsonConverter();
            UserFromJson user = jsonConverter.GetUser();
            SignInPage signInPage = new SignInPage(Driver);
            ProductDetailsPage productDetails = new ProductDetailsPage(Driver);

            NavigateToSignInPage();

            signInPage
                .FillInSignInForm(user)
                .ClickSignInButton();
            homePage
                .ClickMenuButton()
                .ClickAndHoldFirstCategory()
                .ClickFirstSubCategory()
                .ClickInches75TVCategory()
                .ClickFirstProductInGrid();
            productDetails
                .ClickAddToCartButton();

            Assert.True(productDetails.GetTitleSuccessfulAddedProductPopUp().Contains("  You just added 1 item "), "Product successfuly added to cart");

            productDetails
               .ClickViewCartButton();
        }
    }
}
