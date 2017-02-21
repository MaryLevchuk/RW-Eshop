using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebdriverHelpers;


namespace Tests
{
    public class SetupEshopTests : TestsSetup
    {
        public CommonAssistanse User;

        public SetupEshopTests()
        {
            OpenBrowser("chrome");
            User = new CommonAssistanse {Driver = Driver};
            
        }

        [Test]
        public void Link_to_the_shop_should_open_it_in_a_new_browser_tab()
        {

        }

        [Test]
        public void ItIs_AccessibleByUrl_ForLoggedUser()
        {
            //User.LogInToEpiserver();
            //User.OpenPage(TestData.Frontpage);
            //User.ClickOn(Locators.ShopMenu);
            //Driver.Title.Should().Be();
            Thread.Sleep(5000);
        }

        [Test]
        public void ItIs_NotAccessible_ForNotLoggedUser()
        {
        }
        
        [Test]
        public void Eshop_has_different_links_content_in_the_header_and_footer()
        {
        }

        [Test]
        public void Product_templates_and_pages_should_be_supported()
        {
        }

        [Test]
        public void Products_should_support_different_URLs_for_Eshop()
        {
        }

        

        [Test]
        public void It_HasProper_PageName()
        {
        }
    }
}
