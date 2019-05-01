namespace UltimateQA.Test
{
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        { }

        public IWebElement CoursesLink => Driver.FindElement(By.LinkText("Courses"));

        public IWebElement SeleniumResourcesLink => Driver.FindElement(By.XPath(@"//li[@id = ""menu-item-6838""]/a[contains(text(),'Selenium Resources')]"));

        public IWebElement AutomationExercesesLink => Driver.FindElement(By.XPath(@"//li[@id=""menu-item-587""]/a"));

        public IWebElement BlogLink => Driver.FindElement(By.XPath(@"//li[@id=""menu-item-477""]/a[contains(text(), 'Blog')]"));
        
        // All ViewCoursesLinks
        public IList<IWebElement> ViewAllCoursesLinks => Driver.FindElements(By.XPath("//div/a[@data-icon]"));

        public IWebElement FirstViewAllCoursesLink => ViewAllCoursesLinks[0];

        public IWebElement SecondViewAllCoursesLink => ViewAllCoursesLinks[1];


        public IWebElement CompleteSeleniumWebDriverLink => Driver.FindElement(By.XPath("//div/h4/a[contains(text(),'Complete Selenium ')]"));

        public IWebElement WorkingWithElementsLink => Driver.FindElement(By.XPath("//div/h4 /a[contains(text(),'Working with Elements Using Selenium')]"));

        public IWebElement SauceLabsLink => Driver.FindElement(By.XPath("//div/h4/a[contains(text(),'Sauce Labs: Advanced Topics')]"));

        public IWebElement InplicitAndExplicitWaitInSeleniumLink => Driver.FindElement(By.XPath("//div/h4/a[contains(text(),'What are implicit and explicit waits in Selenium?')]"));
    }
}
