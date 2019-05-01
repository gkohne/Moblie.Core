using OpenQA.Selenium;

namespace Test.Driver
{
    public static class WebDriver
    {
        private static IWebDriver _unique_instance;

        public static IWebDriver Inst
        {
            get
            {
                if (_unique_instance == null)
                {
                    _unique_instance = DriverFactory.CreateWebDriver(BrowserType.Chrome);
                }

                return _unique_instance;
            }
        }

        //private static BrowserType? _browserType;
        //public static BrowserType CurrentBrowser
        //{
        //    get
        //    {
        //        if (_browserType == null)
        //        {
        //            _browserType = (BrowserType)int.Parse(System.Configuration.ConfigurationManager.AppSettings["BrowserType"]);
        //        }
        //        return (BrowserType)_browserType;
        //    }
        //}
    }
}
