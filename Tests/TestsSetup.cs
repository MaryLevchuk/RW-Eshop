using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Tests
{
    public abstract class TestsSetup
    {
        public IWebDriver Driver; //{ get; private set; }

       
        public void InitializeDriver(string driverName)
        {
            switch (driverName)
            {
                case "chrome":
                    Driver = new ChromeDriver();
                    break;
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;
                case "ie":
                    Driver = new InternetExplorerDriver();
                    break;
                case "edge":
                    Driver = new EdgeDriver();
                    break;
            }
        }

        
        public void OpenBrowser(string browser)
        {
            InitializeDriver(browser);
            Driver.Manage().Window.Maximize();
        }

        

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(500);
            Driver.Quit();
        }
    }
}
