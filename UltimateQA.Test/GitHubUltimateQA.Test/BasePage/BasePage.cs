
namespace UltimateQA.Test
{
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium;
    using System;
    using OpenQA.Selenium.Support.UI;

    public abstract class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver Driver => this.driver;

        public WebDriverWait Wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10)); 
    }
}
