namespace UltimateQA.Test
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class ManyElementsPage : BasePage
    {

        public ManyElementsPage(IWebDriver driver) : base(driver)
        { }

        // Green Button
        public IList<IWebElement> GreenButton => Wait.Until(d => { return d.FindElements(By.XPath(@"//div/a[@class][contains(text(),'Button')]")); });

        public IWebElement ButtonOne => GreenButton[0];

        public IWebElement ButtonTwo => GreenButton[1];

        public IWebElement ButtonThree => GreenButton[2];

        public IWebElement ButtonFour => GreenButton[3];

        public IWebElement ButtonFive => GreenButton[4];

        public IWebElement ButtonSix => GreenButton[5];

        public IWebElement ButtonSeven => GreenButton[6];

        public IWebElement ButtonEight => GreenButton[7];

        public IWebElement ButtonNine => GreenButton[8];

        public IWebElement ButtonTen => GreenButton[9];

        public IWebElement ButtonEleven => GreenButton[10];

        public IWebElement ButtonTwelve => GreenButton[11];

        // Tweeter Links
        public IList<IWebElement> TweeterFollowLinks => Wait.Until(d => { return d.FindElements(By.XPath(@"//ul/li/a[@title=""Follow on Twitter""]")); });

        public IWebElement TweeterLinkOne => TweeterFollowLinks[0];

        public IWebElement TweeterLinkTwo => TweeterFollowLinks[1];

        public IWebElement TweeterLinkThree => TweeterFollowLinks[2];

        public IWebElement TweeterLinkFour => TweeterFollowLinks[3];

        public IWebElement TweeterLinkFive => TweeterFollowLinks[4];

        // Facebook Links
        public IList<IWebElement> FacebookFollowLinks => Driver.FindElements(By.XPath(@"//li/a[@title=""Follow on Facebook""]"));

        public IWebElement FacebookLinkOne => FacebookFollowLinks[0];

        public IWebElement FacebookLinkTwo => FacebookFollowLinks[1];

        public IWebElement FacebookLinkThree => FacebookFollowLinks[2];

        public IWebElement FacebookLinkFour => FacebookFollowLinks[3];

        public IWebElement FacebookLinkFive => FacebookFollowLinks[4];

        // Fill Form
        public IWebElement Name => Driver.FindElement(By.Id("et_pb_contact_name_0"));

        public IWebElement EmailAddress => Driver.FindElement(By.Id("et_pb_contact_email_0"));

        public IWebElement Message => Driver.FindElement(By.Id("et_pb_contact_message_0"));

        // Find Number Of Task
        public IList<IWebElement> Tasks => Driver.FindElements(By.XPath("//div/p/span"));

        public IWebElement FirstTask => Tasks[0];

        public IWebElement SecondTask => Tasks[1];

        public IWebElement ThirdTask => Tasks[2];

        // Captcha
        public IList<IWebElement> Captchas => Driver.FindElements(By.XPath("//div/p//input[@type='text']"));

        public IWebElement FirstCaptcha => Captchas[0];

        public IWebElement SecondCaptcha => Captchas[1];

        public IWebElement ThirdCaprcha => Captchas[2];

        // Submit Buttons
        public IList<IWebElement> SubmitButtons => Driver.FindElements(By.XPath("//div/button[@type='submit']"));

        public IWebElement FirstSubmitButton => SubmitButtons[0];

        public IWebElement SecondSubmitButton => SubmitButtons[1];

        public IWebElement ThirdSubmitButton => SubmitButtons[2];

        // Text after click submit button
        public IWebElement TextAfterSubmitData => Wait.Until(d => { return d.FindElement(By.XPath(@"//div[@id=""et_pb_contact_form_0""]/div/p")); });
        
    }
}
