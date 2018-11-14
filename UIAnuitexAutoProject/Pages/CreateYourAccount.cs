using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework
{
    public class CreateYourAccount : PageObject
    {
        public CreateYourAccount(IWebDriver driver) : base(driver) { }

        public IWebElement FirstNameField => _driver.FindElement(
            By.XPath(".//input[@name='firstName']"));

        public IWebElement LastNameField => _driver.FindElement(
            By.XPath(".//input[@name='lastName']"));

        public IWebElement EmailAddressField => _driver.FindElement(
            By.XPath(".//input[@data-tl-id='signup-email-input']"));

        public IWebElement CreateAPasswordField => _driver.FindElement(
            By.XPath(".//input[@id='password-su']"));

        public IWebElement CreateAccountButton => _driver.FindElement(
            By.XPath(".//button[@data-automation-id='signup-submit-btn']"));


        public CreateYourAccount FillInFirstNameField(string firstName)
        {
            FirstNameField.SendKeys(firstName);
            return this;
        }

        public CreateYourAccount FillInLastNameField(string lastName)
        {
            LastNameField.SendKeys(lastName);
            return this;
        }

        public CreateYourAccount FillInEmailAddress(string emailField)
        {
            EmailAddressField.SendKeys(emailField);
            return this;
        }

        public CreateYourAccount FillInCreateAPassword(string password)
        {
            CreateAPasswordField.SendKeys(password);
            return this;
        }

        public CreateYourAccount ClickCreateAccountButton()
        {
            CreateAccountButton.Click();
            return this;
        }
    }
}
