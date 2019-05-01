using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static Test.Driver.DriverSelector;

namespace Test.Driver
{
    public class WebDriver
    {
        private IWebDriver _unique_instance;

        public static IWebDriver CreateWebDriver(string browserType)
        {
            IWebDriver driver = null;

            switch(Enum.Parse<BrowserType>(browserType))
            {
                case BrowserType.Chrome:

                    ChromeOptions crOptions = new ChromeOptions();
                    driver = new ChromeDriver(@"C:\Users\gkohne\source\repos\MobileCore\Test\bin\Debug\netcoreapp2.1\",crOptions);
                    break;
            }

            return driver;
        }

        public IWebDriver Inst
        {
            get
            {
                if (_unique_instance == null)
                {
                    _unique_instance = DriverSelector.CreateWebDriver();
                }

                return _unique_instance;
            }
        }

        public IWebDriver Quit()
        {
            _unique_instance.Quit();
            return _unique_instance;
        }

    }
}
