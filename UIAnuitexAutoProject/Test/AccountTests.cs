using NUnit.Framework;
using System;
using UIAnuitexAutoProject.Framework;
using UIAnuitexAutoProject.Framework.HomePage;
using UIAnuitexAutoProject.Framework.Models;

namespace UIAnuitexAutoProject.Test
{
    public class AccountTests : BaseTest
    {
        [Test]
        public void SignInTest()
        {
            HomePage homePage = new HomePage(Driver);
            RightNavMenu rightNavMenu = new RightNavMenu(Driver);            
            JsonConverter jsonConverter = new JsonConverter();
            UserFromJson user = jsonConverter.GetUser();
            SignInPage signInPage = new SignInPage(Driver);
            SignInUserNavMenu signInUserNavMenu = new SignInUserNavMenu(Driver);
            ProfilePage profilePage = new ProfilePage(Driver);
            StringHelper stringHelper = new StringHelper();

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

            var firstleterFName = stringHelper.LeftFirstSymbol(user.FirstName);
            var firstleterLName = stringHelper.LeftFirstSymbol(user.LastName);

            Assert.AreEqual($"{firstleterFName}{firstleterLName}", homePage.GetAcountIconValue(), "User was successfuly sign in");
        }

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
        public void EditProfileFullName()
        {
            HomePage homePage = new HomePage(Driver);
            RightNavMenu rightNavMenu = new RightNavMenu(Driver);
            CreateYourAccount createYourAccount = new CreateYourAccount(Driver);
            ProfilePage profilePage = new ProfilePage(Driver);
            JsonConverter jsonConverter = new JsonConverter();
            UserFromJson user = jsonConverter.GetUser();
            JsonConverter json = new JsonConverter();
            SignInPage signInPage = new SignInPage(Driver);
            SignInUserNavMenu signInUserNavMenu = new SignInUserNavMenu(Driver);


            var fName = $"FN{DateTime.Now.ToString("yyyyMMddHHmmss")}";
            var lName = $"LN{DateTime.Now.ToString("yyyyMMddHHmmss")}";

            homePage
                .ClickAccountIcon();
            rightNavMenu
                .ClickSignInLink();
            signInPage
                .FillInEmailAddressInput(user)
                .FillInPasswordInput(user)
                .ClickSignInButton();
            profilePage
                .ClickAccountIconForSignInUser()
                .ClickAccountLink()
                .ClickProfilePasswordMenuItem()
                .EditFullNameAndSave(fName, lName)
                .ClickSaveButton();

            jsonConverter.ReplaceUserDataInJson(user, fName, lName);

            Assert.AreEqual($"{fName} {lName}", profilePage.GetFullName(), "User Name is changed");
        }
    }
}
