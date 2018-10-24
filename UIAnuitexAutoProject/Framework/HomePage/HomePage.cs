using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework.HomePage
{
    public class HomePage : PageObject
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public IWebElement MenuButton => _driver.FindElement(
            By.XPath(".//button[@aria-label='Menu']"));

        public IWebElement FirstCategory => _driver.FindElement(
            By.XPath(".//div[@data-tl-id='GlobalHeaderDepartmentsMenu-flyout'][2]"));

        public IWebElement FirstSubCategory => _driver.FindElement(
            By.XPath(".//a[@data-uid='LHN-1-DEPT-2']"));

        public IWebElement Inches75TVCategory => _driver.FindElement(
            By.XPath(".//a[@aria-label='75 Inch TVs & Up']"));



        public AllProductInCategoryPage ClickInches75TVCategory()
        {
            Inches75TVCategory.Click();
            return new AllProductInCategoryPage(_driver);
        }

        public HomePage ClickMenuButton()
        {
            MenuButton.Click();
            return this;
        }

        public HomePage ClickAndHoldFirstCategory()
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(FirstCategory).Perform();
            return this;
        }

        public HomePage ClickFirstSubCategory()
        {
            FirstSubCategory.Click();
            return this;
        }
    }
}
