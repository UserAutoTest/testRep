using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework
{
    public class RightNavMenu : PageObject
    {
        public RightNavMenu(IWebDriver driver) : base(driver) { }

        public IWebElement CreateAccountLink => _driver.FindElement(By.XPath(".//div[@class='GlobalAccountMenu-linkDescription']/div[contains(text(), 'Create Account')]"));

        public IWebElement SignInLink => _driver.FindElement(By.XPath(".//div[contains(text(), 'Sign In')]"));

        public RightNavMenu ClickCreateAccountLink()
        {
            Thread.Sleep(100);
            CreateAccountLink.Click();
            return this;
        }

        public RightNavMenu ClickSignInLink()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//div[contains(text(), 'Sign In')]"));
            SignInLink.Click();
            return this;
        }
    }
}
