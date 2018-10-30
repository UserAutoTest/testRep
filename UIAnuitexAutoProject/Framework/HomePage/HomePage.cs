using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework.HomePage
{
    public class HomePage : PageObject
    {    
        public HomePage(IWebDriver driver) : base(driver) { }        

        public IWebElement AccountIcon => _driver.FindElement(
            By.XPath(".//span[@alt='Icon for User Nav']"));

        public IWebElement MenuButton => _driver.FindElement(
            By.XPath(".//span[@class='elc-icon elc-icon-menu']"));

        public IWebElement FirstCategory => _driver.FindElement(
            By.XPath(".//button[@aria-label='Electronics & Office']"));

        public IWebElement FirstSubCategory => _driver.FindElement(
            By.XPath(".//a[contains(text(),'TV & Video')]"));

        public IWebElement Inches75TVCategory => _driver.FindElement(
            By.XPath(".//a[@aria-label='75 Inch TVs & Up']"));

        public IWebElement AcountIconValue => _driver.FindElement(
            By.XPath(".//div[@data-tl-id='GlobalAccountMenu-header']/span"));


        public AllProductInCategoryPage ClickAccountIcon()
        {
            AccountIcon.Click();
            return new AllProductInCategoryPage(_driver);
        }               

        public AllProductInCategoryPage ClickInches75TVCategory()
        {
            Inches75TVCategory.Click();
            return new AllProductInCategoryPage(_driver);
        }

        public HomePage ClickMenuButton()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//span[@class='elc-icon elc-icon-menu']"));
            MenuButton.Click();
            return this;
        }

        
        public HomePage HoverFirstCategory()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//button[@aria-label='Electronics & Office']"));
            Actions action = new Actions(_driver);
            action.MoveToElement(FirstCategory).Perform();          
            return this;
        }

        public HomePage ClickFirstSubCategory()
        {
            var element = _driver.IsElementPresent(By.XPath(".//a[contains(text(),'TV & Video')]"));
            if (element == false)
            {
                HoverFirstCategory();
            }
            FirstSubCategory.Click();
            return this;
        }

        public String GetAcountIconValue()
        {
            string iconValue = AcountIconValue.Text;
            return iconValue;
        }
    }
}
