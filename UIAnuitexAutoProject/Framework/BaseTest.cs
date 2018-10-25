using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject
{
    public class BaseTest
    {         
        private IWebDriver _driver;

        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Driver");
                    _driver = new ChromeDriver(service);
                }
                return _driver;
            }
        }

        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://www.walmart.com/");
            Driver.Manage().Window.Maximize();
        }       

        [TearDown]
        public void TearDown()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();   
                screenshot.SaveAsFile($@"C:\AutoTestsScreenshots\{TestContext.CurrentContext.Test.Name}_{DateTime.Now.ToString("dd-MM-yyyy HH - mm - ss")}", ScreenshotImageFormat.Png);
            }
        }        

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        public void NavigateToSignInPage()
        {
            Driver.Navigate().GoToUrl("https://www.walmart.com/account/login?ref=domain");
        }
    }
}

