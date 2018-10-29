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
            By.XPath(".//div[@class='Price font-bold']/div/span"));

        public IWebElement RemoveProducrButton => _driver.FindElement(
            By.XPath(".//button[@data-tl-id='CartRemoveLnk']/span/span[1]"));

        public IWebElement CartTitle => _driver.FindElement(
            By.XPath(".//h1[@data-automation-id='cart-list-title']/span/span"));



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

        public void ClickRemoveButton()
        {
            RemoveProducrButton.Click();
        }

        public string GetCartTitle()
        {
            string title = CartTitle.Text;
            return title;
        }
    }
}
