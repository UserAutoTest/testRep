using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework
{
    public class CartPage : PageObject
    {
        public CartPage(IWebDriver driver) : base(driver) { }

        public string _prodTitle;

        public string _prodPrice;

        public IWebElement CartProductTitle => _driver.FindElement(
            By.XPath(".//div[@class='cart-item-name js-product-title']/a"));

        public IWebElement CartProductPrice => _driver.FindElement(
            By.XPath(""));


        public string GetProdTitle()
        {
            _prodTitle = CartProductTitle.Text;
            return _prodTitle;
        }

        public string GetCartProductPrice()
        {
            _prodPrice = CartProductPrice.Text;
            return _prodPrice;
        }
    }
}
