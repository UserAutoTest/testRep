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
    public class FirstTest : BaseTest
    {

        [Test]
        public void SuccessPurchaseCheckOutByNotRegistratedUser()
        {
            HomePage homePage = new HomePage(Driver);
            AllProductInCategoryPage televisionsVideoPage = new AllProductInCategoryPage(Driver);
            ProductDetailsPage productDetailsPage = new ProductDetailsPage(Driver);

            homePage
                .ClickMenuButton()
                .ClickAndHoldFirstCategory()
                .ClickFirstSubCategory()
                .ClickInches75TVCategory()
                .ClickFirstProductInGrid()
                .ClickAddToCartButton();

            Assert.True(productDetailsPage.GetTitleSuccessfulAddedProductPopUp().Contains("You just added"));

            productDetailsPage
                .ClickCheckOutButton();
        }
    }
}
