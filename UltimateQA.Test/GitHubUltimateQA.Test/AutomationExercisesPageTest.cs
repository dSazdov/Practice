
namespace UltimateQA.Test
{

    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Reflection;

    public class AutomationExercisesPageTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private AutomationExercisesPage element;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/automation/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            element = new AutomationExercisesPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void PageWithManyElementsLink()
        {
            element.BigPageWithManyElementsLink.Click();
        }

        [Test]
        public void FakeLandingPageLink()
        {
            element.FakeLandingPageLink.Click();
        }

        [Test]
        public void PricingPageLink()
        {
            element.FakePricingPageLink.Click();
        }

        [Test]
        public void FillFormsLink()
        {
            element.FillOutFormsLink.Click();
        }

        [Test]
        public void LearnHowToAutomateLink()
        {
            element.LearnHowToAutomateLink.Click();
        }

        [Test]
        public void LoginAutomationLink()
        {
            element.LoginAutomationLink.Click();
        }

        [Test]
        public void InteractionsWithSimpleElements()
        {
            element.InteractionsWithSimpleElements.Click();
        }


    }
}
