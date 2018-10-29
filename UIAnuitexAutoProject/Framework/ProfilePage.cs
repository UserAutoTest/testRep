using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework
{
    public class ProfilePage : PageObject 
    {
        public ProfilePage(IWebDriver driver) : base(driver) { }

        public IWebElement AccountIconForSignInUser => _driver.FindElement(
            By.XPath(".//button[@data-automation-id='BubbleButtonheader-GlobalHeaderBubblesNav-Account']"));

        public IWebElement ProfilePasswordMenuItem => _driver.FindElement(By.XPath(".//a[@data-title='Profile & Password']"));

        public ProfilePage ClickAccountIconForSignInUser()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//button[@data-automation-id='BubbleButtonheader-GlobalHeaderBubblesNav-Account']"));
            AccountIconForSignInUser.Click();
            return this;
        }

        public ProfilePage ClickProfilePasswordMenuItem()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//a[contains(text(),'Profile & Password')]"));
            ProfilePasswordMenuItem.Click();
            return this;
        }

    }


}
