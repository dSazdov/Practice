
namespace UltimateQA.Test
{

    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class ManyElementsPageTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private ManyElementsPage element;
        private Actions action;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/complicated-page/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            element = new ManyElementsPage(driver);
            action = new Actions(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void VerifyButtonsLoadSamePage()
        {
            element.VerifyGreenButtonsIfLoadOnePage();
        }

        [Test]
        public void VerifyAllTweeterFollowLinksLoadSamePage()
        {

            element.VerifyTweeterLinksIfLoadOnePage();
        }

        [Test]
        public void VerifyAllFacebookFollowLinksLoadSamePage()
        {
            element.VerifyFacebookLinksIfLoadOnePage();
        }

        [Test]
        public void VerifyTextWithAllFilledFields()
        {
            string expectedText = "Thanks for contacting us";
            element.Name.SendKeys("Daniel");
            element.EmailAddress.SendKeys("automationTest@test.test");
            element.Message.SendKeys("Automation quality assurance");
            element.FirstCaptcha.SendKeys(element.SolveFirstTask());
            element.FirstSubmitButton.Click();
            string actualText = element.getHintsAfterClickSubmitButton();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void VerifyTextWithoutFilledFields()
        {
            string expectedText = "Please, fill in the following fields:";
            element.FirstSubmitButton.Click();
            string actualText = element.getHintsAfterClickSubmitButton();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void VerifyTextWithoutNameFilledField()
        {
            string expectedText = "Please, fill in the following fields:";
            element.EmailAddress.SendKeys("automationTest@test.test");
            element.Message.SendKeys("Automation quality assurance");
            element.FirstCaptcha.SendKeys(element.SolveFirstTask());
            element.FirstSubmitButton.Click();
            string actualText = element.getHintsAfterClickSubmitButton();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameField()
        {
            element.Name.SendKeys("Quality Assurance");
            element.FirstSubmitButton.Click();

            Assert.That(element.getHintsForEmptyFields());
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameAndEmailField()
        {
            element.Name.SendKeys("Quality Assurance");
            element.EmailAddress.SendKeys("qualityAssurance@automation.com");
            element.FirstSubmitButton.Click();

            Assert.That(element.getHintsForEmptyFields());
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameEmailAndMessageField()
        {
            element.Name.SendKeys("Quality Assurance");
            element.EmailAddress.SendKeys("qualityAssurance@automation.com");
            element.Message.SendKeys("QA => QualityAssurance!");
            element.FirstSubmitButton.Click();

            Assert.That(element.getHintsForEmptyFields());
        }

        [Test]
        public void VerifyTextOnHintsWithFilledNameAndCaptchaField()
        {
            element.Name.SendKeys("Quality Assurance");
            element.FirstCaptcha.SendKeys(element.SolveFirstTask());
            element.FirstSubmitButton.Click();

            Assert.That(element.getHintsForEmptyFields());
        }
    }
}
