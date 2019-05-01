using NUnit.Framework;
using Test;
using Test.Driver;
using Test.Drivers;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void OpenGoogleVerifyTitle()
        {
            AndriodDriver.Inst.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual("Google", AndriodDriver.Inst.Title);
        }
    }
}