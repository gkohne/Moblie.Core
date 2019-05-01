using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.IO;
using Test.Drivers;
using static Test.Model.SettingsModel;

namespace Test.Driver
{
    public static class DriverSelector
    {
        //public GetDriver()
        //{
        //    string Browser = Settings.Browser;
        //    string AndriodVersion = Settings.AndriodVersion;
        //    bool Mobile = Settings.Mobile;

        //    if (Mobile)
        //    {
        //        AndroidDriver<IWebElement> Driver = MobileDriver.CreateAndriodDriver(AndriodType.x86_Pie_9_API_28);
        //    }
        //    else
        //    {
        //        IWebDriver Driver = WebDriver.CreateWebDriver(BrowserType.Chrome);
        //    }

        //    return Driver;
        //}

        public static IWebDriver CreateWebDriver()
        {
            return WebDriver.CreateWebDriver(Settings.Browser);
        }

        public static AndroidDriver<IWebElement> CreateAndriodDriver()
        {
            return MobileDriver.CreateAndriodDriver(Settings.AndriodVersion);
        }

        public enum AndriodType
        {
            x86_Oreo_8_API_27,
            x86_Pie_9_API_28
        }

        public enum BrowserType
        {
            Chrome,
            Firefox,
            IE,
            Edge
        }

        public static Settings Settings
        {
            get
            {
                using (var streamReader = new StreamReader("Settings.json"))
                {
                    string responseText = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Settings>(responseText);
                }

            }
        }
    }



    //public enum DriverType
    //{
    //    Mobile,
    //    WebDriver
    //}
}
