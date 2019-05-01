using NUnit.Framework;
using Test.Drivers;

namespace Test.Tests
{
    public class AndriodTests
    {
        private MobileDriver mobileDriver;

        [SetUp]
        public void Setup()
        {
            mobileDriver = new MobileDriver();
        }

        [Test]
        public void WebOpenGoogleVerifyTitle()
        {
            mobileDriver.Inst.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual("Google", mobileDriver.Inst.Title);
        }

        [Test]
        public void WebOpenGoogleVerifyTitle2()
        {
            mobileDriver.Inst.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual("Google", mobileDriver.Inst.Title);
        }

        [TearDown]
        public void TearDown()
        {
            mobileDriver.Quit();
        }


    }
}
