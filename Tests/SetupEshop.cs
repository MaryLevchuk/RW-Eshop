using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebdriverHelpers;


namespace Tests
{
    public class SetupEshop : TestsSetup
    {
        public string EshopUrl = "";
        public SetupEshop()
        {
            OpenBrowser("chrome");
            OpenPage(TestData.EshopUrl);
            Driver.WaitElementIsVisible(By.CssSelector(""));
        }

        [Test]
        public void ItIs_AccessibleByUrl_ForLoggedUser()
        {
            //LogInToEpiserver();
            //OpenPage(TestData.EshopUrl);
            //Driver.Title.Should().Be();
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
        public void Link_to_the_shop_should_open_it_in_a_new_browser_tab()
        {
        }

        [Test]
        public void It_HasProper_PageName()
        {
        }
    }
}
