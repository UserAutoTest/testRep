using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject
{
    public class PageObject
    {       
        protected readonly IWebDriver _driver;

        public PageObject(IWebDriver driver)
        {
            this._driver = driver;
        }        
    }
}
