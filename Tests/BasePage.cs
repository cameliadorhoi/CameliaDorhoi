using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewProject
{
    class BasePage
    {
        public IWebDriver Driver { get; set; }
        public BasePage(IWebDriver driver)
        {
            Driver = Driver;         
        }
    }
}
