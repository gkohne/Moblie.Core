using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Chrome;
using System;

namespace Test.Driver
{
    public static class DriverFactory
    {
        public static AndroidDriver<IWebElement> CreateAndriodDriver(AndriodType andriodType)
        {
            AndroidDriver<IWebElement> driver = null;
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("browserName", "Chrome");

            //AppiumLocalService _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            //_appiumLocalService.Start();

            switch (andriodType)
            {
                case AndriodType.Android_Accelerated_x86_Oreo:

                    appiumOptions.AddAdditionalCapability("deviceName",
                        AndriodType.Android_Accelerated_x86_Oreo.ToString());
                    break;

                case AndriodType.x86_Pie_9_API_28:

                    appiumOptions.AddAdditionalCapability("deviceName", AndriodType.x86_Pie_9_API_28.ToString());
                    break;

            }

            try
            {
                driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), appiumOptions);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return driver;
        }

        public static IWebDriver CreateWebDriver(BrowserType browserType)
        {
            IWebDriver driver = null;

            switch (browserType)
            {
                case BrowserType.Chrome:

                    ChromeOptions crOptions = new ChromeOptions();
                    driver = new ChromeDriver(crOptions);

                    break;
            }

            return driver;
        }
    }

    public enum AndriodType
    {
        Android_Accelerated_x86_Oreo,
        x86_Pie_9_API_28
    }

    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE,
        Edge
    }
}
