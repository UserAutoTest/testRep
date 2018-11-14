using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework
{
    public class FulFillmentCheckOut : PageObject
    {
        public FulFillmentCheckOut(IWebDriver driver) : base(driver) { }

        public IWebElement ContinueButton => _driver.FindElement(By.XPath(".//button[@data-tl-id='COAC1FulContBtn']"));

        public IWebElement ContinueButtonAfterShipingAddress => _driver.FindElement(By.XPath(".//button[@data-tl-id='COAC2ShpContBtn']"));

        public IWebElement FirstNameField => _driver.FindElement(By.Id("firstName"));

        public IWebElement LastNameField => _driver.FindElement(By.Id("lastName"));

        public IWebElement PhoneField => _driver.FindElement(By.Id("phone"));

        public IWebElement EmailField => _driver.FindElement(By.Id("email"));

        public IWebElement AddressField => _driver.FindElement(By.Id("addressLineOne"));

        public IWebElement CityField => _driver.FindElement(By.Id("city"));

        public IWebElement PostalCodeField => _driver.FindElement(By.Id("postalCode"));

        public IWebElement StateFieldDropDown => _driver.FindElement(By.Id("state"));

        public IWebElement UseAddressProvidedButton => _driver.FindElement(By.XPath(".//button[@data-tl-id='COAC2ShpAddrSaveAddrBtn']"));


        public FulFillmentCheckOut ClickContinueButton()
        {
            ContinueButton.Click();
            return this;
        }

        public FulFillmentCheckOut WriteFirstNameField(string firstName)
        {
            FirstNameField.SendKeys(firstName);
            return this;
        }

        public FulFillmentCheckOut WriteLastNameField(string lastName)
        {
            LastNameField.SendKeys(lastName);
            return this;
        }

        public FulFillmentCheckOut WritePhoneField(string phoneField)
        {
            PhoneField.SendKeys(phoneField);
            return this;
        }

        public FulFillmentCheckOut WriteEmailField(string emailField)
        {
            EmailField.SendKeys(emailField);
            return this;
        }

        public FulFillmentCheckOut WriteAddressField(string addressField)
        {
            AddressField.SendKeys(addressField);
            return this;
        }

        public FulFillmentCheckOut WriteCityField(string cityField)
        {
            CityField.SendKeys(cityField);
            return this;
        }

        public FulFillmentCheckOut WritePostalCodeField(string postalCodeField)
        {
            PostalCodeField.SendKeys(postalCodeField);
            return this;
        }

        public FulFillmentCheckOut ClickContinueButtonAfterShipingAddress()
        {
            ContinueButtonAfterShipingAddress.Click();
            return this;
        }

        public FulFillmentCheckOut ClickUseAddressProvidedButton()
        {
            UseAddressProvidedButton.Click();
            return this;
        }
    }
}
