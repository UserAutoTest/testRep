using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework.Models;

namespace UIAnuitexAutoProject.Framework
{
    public class ProfilePage : PageObject 
    {
        public ProfilePage(IWebDriver driver) : base(driver) { }

        public IWebElement AccountIconForSignInUser => _driver.FindElement(
            By.XPath(".//button[@data-automation-id='BubbleButtonheader-GlobalHeaderBubblesNav-Account']"));

        public IWebElement ProfilePasswordMenuItem => _driver.FindElement(
            By.XPath(".//a[@data-title='Profile & Password']"));

        public IWebElement EditFullName => _driver.FindElement(
            By.XPath(".//button[@aria-label='Edit Full name']"));

        public IWebElement FirstManeField => _driver.FindElement(By.Id("firstName"));

        public IWebElement LastNameField => _driver.FindElement(By.Id("lastName"));

        public IWebElement SaveButton => _driver.FindElement(
            By.XPath(".//button[@aria-label='Save Full name']"));

        public IWebElement CancelButton => _driver.FindElement(
            By.XPath(".//button[@data-automation-id='name-cancel-button']"));

        public IWebElement ConfirmationPasswordField => _driver.FindElement(
            By.XPath(".//input[@data-tl-id='signin-password-input']"));

        public IWebElement GetUserLogin => _driver.FindElement(
            By.XPath(".//form[@method='post']/div/p"));

        public IWebElement ContinueButton => _driver.FindElement(
            By.XPath(".//button[contains(text(),'Continue')]"));

        public IWebElement FullName => _driver.FindElement(
            By.XPath(".//p[@data-automation-id='name-label']"));


        public SignInUserNavMenu ClickAccountIconForSignInUser()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//button[@data-automation-id='BubbleButtonheader-GlobalHeaderBubblesNav-Account']"));
            AccountIconForSignInUser.Click();
            return new SignInUserNavMenu(_driver);
        }

        public ProfilePage ClickProfilePasswordMenuItem()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//a[contains(text(),'Profile & Password')]"));
            ProfilePasswordMenuItem.Click();
            return this;
        }

        public ProfilePage EditFullNameAndSave(string firstName, string lastName)
        {
            EditFullName.Click();
            FirstManeField.Clear();
            FirstManeField.SendKeys(firstName);

            LastNameField.Clear();
            LastNameField.SendKeys(lastName);  
            return this;
        }

        public ProfilePage ClickSaveButton()
        {
            SaveButton.Click();
            return this;
        }

        public string GetUserLoginFromConfirmPopUp()
        {
            var userlogin = GetUserLogin.Text;
            return userlogin;
        }

        public ProfilePage TypeConfirmationPasswordInPopUp(string pass)
        {
            ConfirmationPasswordField.SendKeys(pass);
            return this;
        }

        public UserFromJson GetUserPassByLogin()
        {
            var login = GetUserLoginFromConfirmPopUp();
            JsonConverter jsonConverter = new JsonConverter();
            UserFromJson currentUserData = jsonConverter.AllUserList.Where(x => x.Login == login).FirstOrDefault();
            return currentUserData;
        }

        public ProfilePage ClickContinueButton()
        {
            ContinueButton.Click();
            return this;
        }

        public string GetFullName()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//p[@data-automation-id='name-label']"));
            var fullName = FullName.Text;
            return fullName;
        }
    }
}
