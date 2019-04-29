using NUnit.Framework;
using Test;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void OpenGoogleVerifyTitle()
        {
            Driver.Inst.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual("Google", Driver.Inst.Title);
        }
    }
}