using OpenQA.Selenium;
using Selenium.WebDriver.Extensions.JQuery;
using By = Selenium.WebDriver.Extensions.JQuery.By;

namespace Tests
{
    public class CommonAssistanse : TestsSetup
    {
        public IWebDriver Driver;

        //public CommonAssistanse()
        //{
           
        //}

        public void OpenPage(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void LogInToEpiserver()
        {
           OpenPage(TestData.TestEnv + TestData.EpiserverPage);
           EnterCredentials();
        }

        private void EnterCredentials()
        {
            IWebElement usernameInput = Driver.FindElement(By.CssSelector(Locators.Username));
            usernameInput.SendKeys(TestData.Username);

            IWebElement passwordInput = Driver.FindElement(By.CssSelector(Locators.Password));
            passwordInput.SendKeys(TestData.Password);

            Driver.FindElement(By.JQuerySelector(Locators.LoginBtn)).Click();
        }

        public void ClickOn(string locator)
        {
            Driver.FindElement(By.CssSelector(locator)).Click();
        }



    }
}
