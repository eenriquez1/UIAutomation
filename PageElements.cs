using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomation
{
   public class PageElements
    {
     
            public  IWebDriver _driver { get; set; }
            //initialize driver constructor
            public PageElements(IWebDriver driver)
            {
                _driver = driver;

            }

            public string username => "webui@email.com";
            public string password => "Automation11!";


            //elements
            public IWebElement SearchTextBox => _driver.FindElement(By.XPath("//input[@id='search']"));
            public IWebElement SignBtn => _driver.FindElement(By.XPath("//a[contains(text(), 'Sign In')]"));
            public IWebElement Usertxt => _driver.FindElement(By.Name("login[username]"));
            public IWebElement Userpw => _driver.FindElement(By.Name("login[password]"));
            public IWebElement Loginbtn => _driver.FindElement(By.Id("send2"));
            public IWebElement TopsTitle => _driver.FindElement(By.CssSelector("#page-title-heading"));

            public By TopsMenu = By.LinkText("Tops");

            public By MenMenu = By.XPath("//span[contains(text(), 'Men')]");
             //image photo of shirt
            public By ItemPhoto = By.LinkText("Cassius Sparring Tank");
             //Add to wishlist button
           public By AddToWishbtn => By.XPath("//span[contains(text(), 'Add to Wish List')]");
           //Add to Cart from wishlist butn
           public By AddtoCartFRomWishbtn = By.XPath("//button[@title='Add All to Cart']");
           public By MediumSizebtn = By.XPath("//div[contains(@class, 'product-options-wrapper')]//div[contains(text(), 'M')]");
           public By BlueColorOptionbtn = By.Id("option-label-color-93-item-50");
           public By RemoveWishList = By.XPath("//a[contains(@class, 'btn-remove') and contains(@class, 'action') and contains(@class, 'delete')]");
           public By TopRightArrowbtn = By.XPath("//button[contains(@class, 'action') and contains(@class, 'switch')]");
           public By MyWishListbtn = By.LinkText("My Wish List");
           public By AddToCartbtn = By.XPath("//button[@title='Add to Cart']");
           public By AddToCarHyperlink = By.LinkText("shopping cart");
           public By ProceedToCheckOutbtn = By.XPath("//span[contains(text(), 'Proceed to Checkout')]");
           public By AddNewAddressbtn = By.CssSelector("div.new-address-popup > button");
           public By SaveAddressCheckbx = By.XPath("//input[contains(@class, 'checkbox') and contains(@id, 'shipping-save-in-address-book')]");
           public By ShipHerebtn = By.XPath("//span[contains(text(), 'Ship here')]");
           public By NextCheckoutbtn = By.XPath("//span[contains(text(), 'Next')]");
           public By StreetTxt = By.XPath("//input[contains(@class, 'input-text') and contains(@name, 'street[0]')]");
           public By CityTxt = By.XPath("//input[contains(@class, 'input-text') and contains(@name, 'city')]");
           public By Ziptxt = By.XPath("//input[contains(@class, 'input-text') and contains(@name, 'postcode')]");
           public By PhoneTxt = By.XPath("//input[contains(@class, 'input-text') and contains(@name, 'telephone')]");
           public By PlaceOrderbtn = By.XPath("//span[text()='Place Order']");
           public By Cancelbtn = By.XPath("//span[text()='Cancel']");
           public By RadioShippingFree = By.XPath("//input[contains(@class, 'radio') and contains(@name, 'ko_unique_3')]");
          public By  SameShipSameBillChekbx = By.XPath("//input[contains(@type, 'checkbox') and contains(@name, 'billing-address-same-as-shipping')]");
        public IWebElement productSearch => _driver.FindElement(By.XPath("//div[contains(@class, 'products') and contains(@class, 'products-grid')]"));
          public string CartRequiredMessage = "This is a required field.";
        public IWebElement StateDropdown => _driver.FindElement(By.CssSelector("div.control > select"));
        //no search message
       public  IWebElement Searchmessage => _driver.FindElement(By.XPath("//div[contains(text(), 'Your search returned no results. ')]"));

        public IWebElement WishListEmptyMessage =>_driver.FindElement(By.XPath("//span[contains(text(),'You have no items in your wish list.']"));
        //wishlist textbox
           public IWebElement WishTxt => _driver.FindElement(By.Id("qty"));
           
        //Login assert
            public string LoginExpected => "Welcome, WebUI Automation!";
           public string actualMessage => _driver.FindElement(By.XPath("//span[@class='logged-in']")).Text;
        

    }
}

