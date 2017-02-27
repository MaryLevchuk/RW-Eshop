using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;


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
            User.OpenPage(TestData.Frontpage);
            User.ClickOn(Locators.ShopMenu);
            IList<string> allWindowHandles = Driver.WindowHandles;
            Thread.Sleep(1000);
            allWindowHandles.Count.Should().BeGreaterThan(1);
        }

        [Test]
        public void ShopPage_HasProper_Name()
        {
            User.OpenPage(TestData.Frontpage + TestData.EshopUrl);
            Thread.Sleep(1000);
            Driver.Title.Should().Contain("Shop - ROCKWOOL");
        }

        
        [Test]
        [Explicit]
        public void ItIs_AccessibleByUrl_ForLoggedUser()
        {
        }

        [Test]
        [Explicit]
        public void ItIs_NotAccessible_ForNotLoggedUser()
        {
        }
        
        [Test]
        [Explicit]
        public void Eshop_has_different_links_content_in_the_header_and_footer()
        {
        }

        [Test]
        [Explicit]
        public void Product_templates_and_pages_should_be_supported()
        {
        }

        [Test]
        [Explicit]
        public void Products_should_support_different_URLs_for_Eshop()
        {
        }

        

        
    }
}
