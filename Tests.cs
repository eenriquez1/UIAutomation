using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace UIAutomation
{
    
    public class Tests
    {
        IWebDriver _driver = new ChromeDriver();

        
        [OneTimeSetUp]
        public void Setup()
        {

            _driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            Login();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

      
        private void Login()
        {
            
            PageElements _pageElements = new PageElements(_driver);


            _pageElements.SignBtn.Click();
            _pageElements.Usertxt.Clear();
            _pageElements.Userpw.Clear();
            _pageElements.Usertxt.SendKeys(_pageElements.username);
            _pageElements.Userpw.SendKeys(_pageElements.password);
            _pageElements.Loginbtn.Click();
            Thread.Sleep(3000);
            Assert.AreEqual(_pageElements.LoginExpected, _pageElements.actualMessage, "Login Unsuccessful");



        }

       

        [Test]
        public void ManageWishlist()
        {
          
            PageElements _pageElements = new PageElements(_driver);
            PageActions actions = new PageActions(_driver);

            //Fail TC- added to wish with no options
            actions.AddToWishFail(_pageElements.MenMenu, _pageElements.TopsMenu, _pageElements.ItemPhoto,
               _pageElements.AddToWishbtn)

            .AddToWish(_pageElements.MenMenu, _pageElements.TopsMenu, _pageElements.ItemPhoto,
                _pageElements.MediumSizebtn, _pageElements.BlueColorOptionbtn, _pageElements.AddToWishbtn);

            
           
        }

        [Test]
        public void ManageCart()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            PageElements p = new PageElements(_driver);
            PageActions actions = new PageActions(_driver);


            //Faile TC- proceed without options selected
            actions.AddToCartFail(p.MenMenu, p.TopsMenu, p.ItemPhoto,
              p.AddToCartbtn);

            actions.AddToCart(p.MenMenu, p.TopsMenu, p.ItemPhoto, p.MediumSizebtn, p.BlueColorOptionbtn,
                p.AddToCartbtn, p.AddToCarHyperlink);

            //Fail TC checkout - proceed without required address fields
            actions.CheckoutFail(p.ProceedToCheckOutbtn, p.AddNewAddressbtn, p.Cancelbtn, p.ShipHerebtn);

            actions.Checkout(p.AddNewAddressbtn, p.StreetTxt, p.CityTxt, p.Ziptxt,
            p.PhoneTxt, p.SaveAddressCheckbx, p.ShipHerebtn, p.RadioShippingFree, p.NextCheckoutbtn, p.SameShipSameBillChekbx, p.PlaceOrderbtn, p.StateDropdown);

        }

        [Test]
        public void Search()
        {
            PageActions actions = new PageActions(_driver);
            actions.Search();
        }


    }
}