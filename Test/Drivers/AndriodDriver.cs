using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using Test.Driver;

namespace Test.Drivers
{
    public static class AndriodDriver
    {
        private static AndroidDriver<IWebElement> _unique_instance;

        public static AndroidDriver<IWebElement> Inst
        {
            get
            {
                if (_unique_instance == null)
                {
                    _unique_instance = DriverFactory.CreateAndriodDriver(AndriodType.x86_Pie_9_API_28);
                }

                return _unique_instance;
            }
        }
    }
}
