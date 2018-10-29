using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework
{
    public class AllProductInCategoryPage : PageObject
    {
        public AllProductInCategoryPage(IWebDriver driver) : base(driver) { }

        public string _productTitle;
        public string _productPrice;

        public IWebElement FirstProductInGrid => _driver.FindElement(
            By.XPath(".//li[@data-tl-id='ProductTileGridView-0']//a[@class='display-block']"));

        public IWebElement ProductPrice => _driver.FindElement(
            By.XPath(".//span[@class='price display-inline-block arrange-fit price price-main']/span"));

        public IWebElement ProductTitle => _driver.FindElement(
            By.XPath(".//ul[@class='search-result-gridview-items four-items']/li[1]//div[@class='search-result-product-title gridview']/span/a"));

        public ProductDetailsPage ClickFirstProductInGrid()
        {
            FirstProductInGrid.Click();
            return new ProductDetailsPage(_driver);
        }

        public string GetProductTitle()
        {
            _productTitle = ProductTitle.Text;
            return _productPrice;
        }

        public string GetProductPrice()
        {
            _productPrice = ProductPrice.Text;
            return _productPrice;
        }
    }
}
