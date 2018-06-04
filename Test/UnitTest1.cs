using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void can_Go_To_LinkedInSignIn()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());

        }

        [TestMethod]
        public void LinkedInLogin()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.ClickSignIn();
           
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
