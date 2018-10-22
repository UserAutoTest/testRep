using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework.HomePage
{
    public class HomePage: PageObject
    {
        public HomePage(IWebDriver driver): base(driver) { }

        public IWebElement MenuButton => _driver.FindElement(By.XPath(".//button[@aria-label='Menu']"));

        public IWebElement CategoryList => _driver.FindElement(By.XPath(".//div[@data-tl-id='GlobalHeaderDepartmentsMenu-flyout']"));

        public HomePage ClickMenuButton()
        {
            MenuButton.Click();
            return this;
        }

        public IList<String> GetAllCategoryList()
        {
            List<String> categoryList = new List<String>();
            categoryList.Add(CategoryList.Text);
            return categoryList;
        }

    }
}
