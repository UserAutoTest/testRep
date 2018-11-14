using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework
{
    public class SignInUserNavMenu : PageObject 
    {
        public SignInUserNavMenu(IWebDriver driver) : base(driver) { }

        public IWebElement AccountLink => _driver.FindElement(By.XPath(".//div[contains(text(),'Account')]"));

        public ProfilePage ClickAccountLink()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//div[contains(text(),'Account')]"));
            AccountLink.Click();
            return new ProfilePage(_driver);
        }
    }
}
