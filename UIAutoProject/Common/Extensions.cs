using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework
{
    public static class Extensions
    {
        public static void WaitForElementToBeVisible(this IWebDriver driver, By by, Int32 seconds = 50)
        {
            Int32 timeOutInSeconds = TimeSpan.FromSeconds(seconds).Seconds;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(c=>c.FindElement(by));
        }

        public static bool IsElementPresent(this IWebDriver driver, By by)
        {           
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {               
                return false;
            }
        }

        public static IRestRequest AddOrUpdatBody(this IRestRequest restRequest, object obj)
        {
            string serialized = JsonConvert.SerializeObject(obj);

            string contentType = "application/json";

            return restRequest.AddOrUpdateParameter(contentType, serialized, ParameterType.RequestBody);
        }
    }
}
