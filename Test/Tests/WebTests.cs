using NUnit.Framework;
using Test;
using Test.Driver;
using Test.Drivers;

namespace Test.Tests
{
    public class Tests
    {
        private WebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new WebDriver();
        }

        [Test]
        public void WebOpenGoogleVerifyTitle()
        {
            webDriver.Inst.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual("Google", webDriver.Inst.Title);
        }

        [Test]
        public void WebOpenGoogleVerifyTitle2()
        {
            webDriver.Inst.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual("Google", webDriver.Inst.Title);
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}