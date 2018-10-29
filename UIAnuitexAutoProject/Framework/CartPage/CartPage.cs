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
            _driver.WaitForElementToBeVisible(By.XPath(".//button[@data-tl-id='CartRemoveLnk']/span/span[1]"));
            RemoveProducrButton.Click();
        }

        public string GetCartTitle()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//h1[@aria-label='0 items in your cart 0 items']"));
            string title = CartTitle.Text;
            return title;
        }
    }
}
