
namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public partial class HomePage
    {

        public void VerifyBothViewAllCoursesLinkLoadSamePage()
        {
            HomePage element = new HomePage(Driver);
            
            IWebElement elementOne = element.ViewAllCoursesLinks[0];
            elementOne.Click();
            string addressFirstLink = Driver.Title;
            Driver.Navigate().Back();

            IWebElement elementTwo = element.ViewAllCoursesLinks[1];
            elementTwo.Click();
            string addressSecondLink = Driver.Title;

            Assert.AreEqual(addressFirstLink, addressSecondLink);
        }
    }
}
