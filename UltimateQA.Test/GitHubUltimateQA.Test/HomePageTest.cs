
namespace UltimateQA.Test
{

    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    public class HomePageTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private HomePage element;
        private Actions action;

        [SetUp]
        public void SetUp()
        {

            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.ultimateqa.com");

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            element = new HomePage(driver);

            action = new Actions(driver);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        
        [Test]
        public void CourseLink()
        {
            
            element.CoursesLink.Click();

        }

        [Test]
        public void SeleniumResourcesLink()
        {
           
            element.SeleniumResourcesLink.Click();
            
        }

        [Test]
        public void AutomationExercesesLink()
        {

            element.AutomationExercesesLink.Click();
            
        }

        [Test]
        public void BlogLink()
        {

            element.BlogLink.Click();

        }
        
        [Test]
        public void ViewAllCoursesFirstLink()
        {

            element.FirstViewAllCoursesLink.Click();
            
        }

        [Test]
        public void ViewAllCoursesSecondLink()
        {
           
            element.SecondViewAllCoursesLink.Click();

        }

        [Test]
        public void VerifyBothViewAllCoursesLinkLoadOnePage()
        {

            element.VerifyBothViewAllCoursesLinkLoadSamePage();
        }

        [Test]
        public void CompleteSeleniumWebDriverWithCSharpLink()
        {
            action.MoveToElement(element.CompleteSeleniumWebDriverLink);
            action.Perform();
            element.CompleteSeleniumWebDriverLink.Click();
        }

        [Test]
        [Ignore("The connection is not secure")]
        public void SauceLabsAdvancedTopicsLink()
        {
            action.MoveToElement(element.SauceLabsLink);
            action.Perform();
            
            element.SauceLabsLink.Click();
            
        }

        [Test]
        public void InplicitAndExplicitWaitLink()
        {

            element.InplicitAndExplicitWaitInSeleniumLink.Click();
        }

        




    }

}



