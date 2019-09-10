using System;
using OpenQA.Selenium;

namespace NewProject
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement siteDescriptionTitle => Driver.FindElement(By.CssSelector("#editorial_block_center h1"));
        public IWebElement meniu => Driver.FindElement(By.Id("block_top_menu"));
        public IWebElement summerCollection => Driver.FindElement(By.XPath("//*[@id='htmlcontent_top']/ul/li[2]/a/img"));

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }


               
               

    }
}
