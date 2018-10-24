using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework
{
    public class RightNavMenu : PageObject
    {
        public RightNavMenu(IWebDriver driver) : base(driver) { }

        public IWebElement CreateAccountLink => _driver.FindElement(By.XPath(".//div[contains(text(), 'Create Account')]"));

        public IWebElement SignInLink => _driver.FindElement(By.XPath(".//div[contains(text(), 'Sign In')]"));

        public RightNavMenu ClickCreateAccountLink()
        {
            CreateAccountLink.Click();
            return this;
        }

        public RightNavMenu ClickSignInLink()
        {
            SignInLink.Click();
            return this;
        }
    }
}
