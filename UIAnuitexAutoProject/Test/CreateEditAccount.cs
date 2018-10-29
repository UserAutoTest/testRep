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
        public void AddProductInCartUnloggedUser()
        {
            HomePage homePage = new HomePage(Driver);
            RightNavMenu rightNavMenu = new RightNavMenu(Driver); 
            ProductDetailsPage productDetails = new ProductDetailsPage(Driver);
            AllProductInCategoryPage allProductInCategory = new AllProductInCategoryPage(Driver);
            CartPage cartPage = new CartPage(Driver);
                       
            homePage
                .ClickMenuButton()
                .DoublClickOrHoverFirstCategory()
                .ClickFirstSubCategory()
                .ClickInches75TVCategory();

            string profuctPrice = allProductInCategory.GetProductPrice();

            allProductInCategory
               .ClickFirstProductInGrid();
            productDetails
                .ClickAddToCartButton()
                .ClickViewCartButton();

            string cartProfuctPrice = cartPage.GetCartProductPrice();
            
            Assert.AreEqual(profuctPrice, cartProfuctPrice, "product add to cart and Price are equal");
        }

        [Test]
        public void AddAndRemoveProductFromCart()
        {
            HomePage homePage = new HomePage(Driver);
            RightNavMenu rightNavMenu = new RightNavMenu(Driver);
            ProductDetailsPage productDetails = new ProductDetailsPage(Driver);
            AllProductInCategoryPage allProductInCategory = new AllProductInCategoryPage(Driver);
            CartPage cartPage = new CartPage(Driver);

            homePage
                .ClickMenuButton()
                .DoublClickOrHoverFirstCategory()
                .ClickFirstSubCategory()
                .ClickInches75TVCategory();
            allProductInCategory
               .ClickFirstProductInGrid();
            productDetails
                .ClickAddToCartButton()
                .ClickViewCartButton();
            cartPage
                .ClickRemoveButton();


            Assert.IsTrue(cartPage.GetCartTitle().Contains("0 items in your cart"), "Title isn't null");
        }
    }
}
