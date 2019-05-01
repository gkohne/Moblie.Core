using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using Test.Driver;

namespace Test.Drivers
{
    public class AndriodDriver
    {
        private AndroidDriver<IWebElement> _unique_instance;

        public AndroidDriver<IWebElement> Inst
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

        public AndroidDriver<IWebElement> Quit()
        {
            _unique_instance.Quit();

            return _unique_instance;
        }
    }
}
