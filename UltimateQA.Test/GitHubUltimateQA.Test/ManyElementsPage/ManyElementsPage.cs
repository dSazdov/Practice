
namespace UltimateQA.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class ManyElementsPage
    {
        private ManyElementsPage element;


        public void VerifyGreenButtonsIfLoadOnePage()
        {

            for (int i = 0; i < element.GreenButton.Count(); i++)
            {

                string expectedTitle = "Complicated Page - Ultimate QA";
                IWebElement button = element.GreenButton[i];
                button.Click();
                string actualTitle = Driver.Title;

                Assert.AreEqual(expectedTitle, actualTitle);
            }

        }

        public void VerifyTweeterLinksIfLoadOnePage()
        {
            for (int i = 0; i < element.TweeterFollowLinks.Count(); i++)
            {
                string expectedTitle = "Nikolay Advolodkin (@Nikolay_A00) | Twitter";
                IWebElement link = element.TweeterFollowLinks[i];
                link.Click();
                string actualTitle = Driver.Title;
                Driver.Navigate().Back();

                Assert.AreEqual(expectedTitle, actualTitle);

            }
        }

        public void VerifyFacebookLinksIfLoadOnePage()
        {

            element = new ManyElementsPage(Driver);

            for (int i = 0; i < FacebookFollowLinks.Count(); i++)
            {
                string expectedTitle = "Ultimate QA - Home | Facebook";
                IWebElement link = FacebookFollowLinks[i];
                link.Click();
                string actualTitle = Driver.Title;
                Driver.Navigate().Back();

                Assert.AreEqual(expectedTitle, actualTitle);

            }
        }

        public string SolveFirstTask()
        {
            element = new ManyElementsPage(Driver);

            string[] getNumber = element.FirstTask.Text.Split(" + ");
            int addNumber = int.Parse(getNumber[0]) + int.Parse(getNumber[1]);
            string solvedTask = addNumber.ToString();
            return solvedTask;

        }

        public string getHintsAfterClickSubmitButton()
        {
            element = new ManyElementsPage(Driver);
            string text = element.TextAfterSubmitData.Text;
            return text;
        }

        public bool getHintsForEmptyFields()
        {
            element = new ManyElementsPage(Driver);
            bool isEqual = false;
            
            IList<IWebElement> getFieldsThatShouldBeFill = Driver.FindElements(By.XPath(@"//div[@id=""et_pb_contact_form_0""]/div/ul/li"));

            string nameField = element.Name.GetAttribute("value");
            string emailField = element.EmailAddress.GetAttribute("value");
            string messageField = element.Message.GetAttribute("value");
            string captchaField = element.FirstCaptcha.GetAttribute("value");

            List<string> expectedHints = new List<string>();
            List<string> actualHints = new List<string>(); 

            if (nameField == string.Empty)
            {
                expectedHints.Add("Name");
            }

            if (emailField == string.Empty)
            {
                expectedHints.Add("Email Address");
            }

            if (messageField == string.Empty)
            {
                expectedHints.Add("Message");
            }

            if (captchaField == string.Empty)
            {
                expectedHints.Add("Captcha");
            }

            for (int i = 0; i < getFieldsThatShouldBeFill.Count; i++)
            {
                actualHints.Add(getFieldsThatShouldBeFill[i].Text);
            }

            if (expectedHints.SequenceEqual(actualHints))
            {
                isEqual = true;
            }

            return isEqual;

        }
        
    }
}