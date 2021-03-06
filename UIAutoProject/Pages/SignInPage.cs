﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using UIAutoProject.Framework.Models;

namespace UIAutoProject.Framework
{
    public class SignInPage : PageObject
    {
        public SignInPage(IWebDriver driver) : base(driver) { }

        public IWebElement EmailAddressInput => _driver.FindElement(By.XPath(".//input[@data-tl-id='signin-email-input']"));

        public IWebElement PasswordInput => _driver.FindElement(By.XPath(".//input[@data-tl-id='signin-password-input']"));

        public IWebElement SignInButton => _driver.FindElement(By.XPath(".//button[@data-automation-id='signin-submit-btn']"));
        
        public SignInPage FillInEmailAddressInput(User user)
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//input[@data-tl-id='signin-email-input']"));
            EmailAddressInput.SendKeys(user.Login);
            return this;
        }

        public SignInPage FillInPasswordInput(User user)
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//input[@data-tl-id='signin-password-input']"));
            PasswordInput.SendKeys(user.Password);
            return this;
        }

        public SignInPage FillInSignInForm(User user)
        {
            EmailAddressInput.SendKeys(user.Login);
            PasswordInput.SendKeys(user.Password);
            return this;
        }

        public SignInPage ClickSignInButton()
        {
            _driver.WaitForElementToBeVisible(By.XPath(".//button[@data-automation-id='signin-submit-btn']"));
            SignInButton.Click();
            return this;
        }

    }
}
