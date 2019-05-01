using NUnit.Framework;
using Test;
using Test.Driver;
using Test.Drivers;
using Test.Model;

namespace Test.Tests
{
    public class Tests
    {
        private WebDriver webDriver;
        private string Url = string.Empty;

        [OneTimeSetUp]
        public void OneTime()
        {
            SettingsModel.Settings SettingsUrl = DriverSelector.Settings;
            Url = SettingsUrl.URL;
        }

        [SetUp]
        public void Setup()
        {
            webDriver = new WebDriver();
        }

        [Test]
        public void WebOpenGoogleVerifyTitle()
        {
            webDriver.Inst.Navigate().GoToUrl(Url);
            Assert.AreEqual("Google", webDriver.Inst.Title);
        }

        [Test]
        public void WebOpenGoogleVerifyTitle2()
        {
            webDriver.Inst.Navigate().GoToUrl(Url);
            Assert.AreEqual("Google", webDriver.Inst.Title);
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}