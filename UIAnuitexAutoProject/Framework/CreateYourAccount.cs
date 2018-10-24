using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework
{
    public class CreateYourAccount : PageObject
    {
        public CreateYourAccount(IWebDriver driver) : base(driver) { }

        public IWebElement FirstNameField => _driver.FindElement(By.XPath(".//input[@name='firstName']"));

        public IWebElement LastNameField => _driver.FindElement(By.XPath(".//input[@name='lastName']"));

        public IWebElement EmailAddressField => _driver.FindElement(By.XPath(".//input[@name='email']"));

        public IWebElement CreateAPasswordField => _driver.FindElement(By.XPath(".//input[@name='password']"));

        public IWebElement CreateAccountButton => _driver.FindElement(By.XPath(".//button[@type='submit']"));


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

        public CreateYourAccount FillInEmailAddress(string phoneField)
        {
            EmailAddressField.SendKeys(phoneField);
            return this;
        }

        public CreateYourAccount FillInCreateAPassword(string emailField)
        {
            CreateAPasswordField.SendKeys(emailField);
            return this;
        }

        public CreateYourAccount ClickCreateAccountButton()
        {
            CreateAccountButton.Click();
            return this;
        }
    }
}
