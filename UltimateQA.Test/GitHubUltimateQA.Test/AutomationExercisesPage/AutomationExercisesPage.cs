namespace UltimateQA.Test
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;

    public class AutomationExercisesPage : BasePage
    {
        public AutomationExercisesPage(IWebDriver driver) : base(driver)
        { }
        
        public IList<IWebElement> AllElementsLink => Driver.FindElements(By.XPath(@"//div[@class=""et_pb_text_inner""]/ul/li/a"));

        public IWebElement BigPageWithManyElementsLink => AllElementsLink[0];

        public IWebElement FakeLandingPageLink => AllElementsLink[1];

        public IWebElement FakePricingPageLink => AllElementsLink[2];

        public IWebElement FillOutFormsLink => AllElementsLink[3];

        public IWebElement LearnHowToAutomateLink => AllElementsLink[4];

        public IWebElement LoginAutomationLink => AllElementsLink[5];

        public IWebElement InteractionsWithSimpleElements => AllElementsLink[6];

        
    }
}
