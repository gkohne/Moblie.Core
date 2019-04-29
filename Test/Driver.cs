using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;
using static Test.DriverFactory;

namespace Test
{
    public static class Driver
    {
        private static IWebDriver _unique_instance;
        public static IWebDriver Inst
        {
            get
            {
                if (_unique_instance == null)
                {
                    _unique_instance = DriverFactory.CreateWebDriver(AndriodType.Android_Accelerated_x86_Oreo);
                }

                return _unique_instance;
            }
        }
    }
    public static class DriverFactory
    {
        public static IWebDriver CreateWebDriver(AndriodType andriodType)
        {
            AndroidDriver<IWebElement> driver = null;

            switch (andriodType)
            {
                case AndriodType.Android_Accelerated_x86_Oreo:

                    AppiumOptions appiumrOptions = new AppiumOptions();
                    appiumrOptions.AddAdditionalCapability("deviceName", AndriodType.Android_Accelerated_x86_Oreo.ToString());
                    appiumrOptions.AddAdditionalCapability("platformName", "Android");
                    appiumrOptions.AddAdditionalCapability("browserName", "Chrome");

                    try
                    {
                        driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), appiumrOptions);
                    }
                    catch (Exception ex)
                    {
                        string error = ex.Message;
                    }

                    break;

                case AndriodType.Android_Accelerated_x86_Marshmellow:

                    break;

            }

            return driver;
        }

        public enum AndriodType
        {
            Android_Accelerated_x86_Oreo,
            Android_Accelerated_x86_Marshmellow
        }
    }
}
