using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework;
using UIAnuitexAutoProject.Framework.HomePage;
using UIAnuitexAutoProject.Framework.Models;

namespace UIAnuitexAutoProject.Test
{
    public class CartTests : BaseTest
    {
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
                .HoverFirstCategory()
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
                .HoverFirstCategory()
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
