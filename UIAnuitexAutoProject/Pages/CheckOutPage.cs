using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework
{
    public class CheckOutPage : PageObject
    {
        public CheckOutPage(IWebDriver driver) : base(driver) { }

        public IWebElement ContinueButton => _driver.FindElement(By.XPath(".//button[@data-tl-id='Wel-Guest_cxo_btn']/span"));

        public CheckOutPage ClickContinueButton()
        {
            ContinueButton.Click();
            return this;
        }

    }
}
