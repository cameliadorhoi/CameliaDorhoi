using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace NewProject
{
    internal class WebDriverFactory
    {
        public WebDriverFactory()
        {

        }

        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                case BrowserType.FireFox:
                    return GetFireFoxDriver();
                default:
                    throw new ArgumentOutOfRangeException("No such browser exists");
            }
        }

        private IWebDriver GetFireFoxDriver()
        {
            var options = new FirefoxOptions();
            var firefoxPath = "C:/Users/cameliadorhoi/.nuget/packages/selenium.firefox.webdriver/0.24.0/driver";
            options.AddArgument("--start-maximized");
            options.AddArgument("--ignore-certificate-errors");
            return new FirefoxDriver(firefoxPath, options);
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            var chromePath = "C:/Users/cameliadorhoi/.nuget/packages/selenium.webdriver.chromedriver/76.0.3809.12600/driver/win32";
            options.AddArgument("--start-maximized");
            options.AddArgument("--ignore-certificate-errors");
            return new ChromeDriver(chromePath, options);
        }
    }

}
