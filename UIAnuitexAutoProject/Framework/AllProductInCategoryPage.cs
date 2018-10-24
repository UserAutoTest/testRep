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

        public IWebElement FirstProductInGrid => _driver.FindElement(
            By.XPath(".//li[@data-tl-id='ProductTileGridView-0']//a[@class='display-block']"));

        public ProductDetailsPage ClickFirstProductInGrid()
        {
            FirstProductInGrid.Click();
            return new ProductDetailsPage(_driver);
        }
    }
}
