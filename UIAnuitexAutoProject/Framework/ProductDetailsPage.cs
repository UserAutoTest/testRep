using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework
{
    public class ProductDetailsPage : PageObject
    {
        public ProductDetailsPage(IWebDriver driver) : base(driver) { }

        public IWebElement AddToCardButton => _driver.FindElement(
            By.XPath(".//span[@class='spin-button-children']"));

        public IWebElement SuccessfulAddedProductPopUp => _driver.FindElement(
            By.XPath("//span[@class='heading-success']/span"));

        public IWebElement ViewCartButton => _driver.FindElement(
            By.XPath(".//button[@data-automation-id='pac-pos-view-cart']"));

        public IWebElement CheckOutButton => _driver.FindElement(
            By.XPath(".//button[@data-automation-id='cart-pos-proceed-to-checkout'][1]"));

        public ProductDetailsPage ClickAddToCartButton()
        {
            AddToCardButton.Click();
            return this;
        }

        public string GetTitleSuccessfulAddedProductPopUp()
        {

            string title = SuccessfulAddedProductPopUp.Text;
            return title;
        }

        public ProductDetailsPage ClickViewCartButton()
        {
            ViewCartButton.Click();
            return this;
        }

        public CheckOutPage ClickCheckOutButton()
        {
            CheckOutButton.Click();
            return new CheckOutPage(_driver);
        }
    }
}
