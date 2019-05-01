using OpenQA.Selenium;
using Test.Drivers;

namespace Test.Driver
{
    public class WebDriver
    {
        private IWebDriver _unique_instance;

        public IWebDriver Inst
        {
            get
            {
                if (_unique_instance == null)
                {
                    _unique_instance = DriverSelector.CreateWebDriver(BrowserType.Chrome);
                }

                return _unique_instance;
            }
        }

        public IWebDriver Quit()
        {
            _unique_instance.Quit();

            DisposeDriverService.KillAllBrowsers(_unique_instance);

            return _unique_instance;
        }

    }
}
