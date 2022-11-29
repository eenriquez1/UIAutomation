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

   public class PageActions
    {
        private readonly  IWebDriver _driver;

    public PageActions(IWebDriver driver)
        {
            _driver = driver;
            
        }
      
   


        public PageActions AddToWish(By Mens, By Tops, By item, By size, By color,
            By AddWish)
        {
            Actions act = new Actions(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Hover over Men tab and click it to access Men menu
            _driver.FindElement(Mens).Click();
            // Click Tops hyperlink to access items
            _driver.FindElement(Tops).Click();
            //Click item
            _driver.FindElement(item).Click();
            //Select size and color
            _driver.FindElement(size).Click();
            _driver.FindElement(color).Click();
            //add to wishlist
            _driver.FindElement(AddWish).Click();
            return this;
        }



        //Fail TC
        public PageActions AddToWishFail(By ele, By ele2, By ele3, By ele4)
        {

            Actions act = new Actions(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            act.ContextClick();
            //Hover over Men tab and click it to access Men menu
            _driver.FindElement(ele).Click();
            // Click Tops hyperlink to access items
            _driver.FindElement(ele2).Click();
            //Click item
            _driver.FindElement(ele3).Click();
            //Add to wish
            _driver.FindElement(ele4).Click();
            return this;
        }

        public PageActions AddToCart(By ele, By ele2, By ele3, By ele4, By ele5,
            By ele6, By ele7){

            Actions act = new Actions(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            act.ContextClick();
            //Hover over Men tab and click it to access Men menu
            _driver.FindElement(ele).Click();
            // Click Tops hyperlink to access items
            _driver.FindElement(ele2).Click();
            //Click item
            _driver.FindElement(ele3).Click();
            //Select size and color
            _driver.FindElement(ele4).Click();
            _driver.FindElement(ele5).Click();
            //add to cart
            _driver.FindElement(ele6).Click();
            //Go to cart
            _driver.FindElement(ele7).Click();
             return this;


        }

        public PageActions AddToCartFail(By Mens, By Tops, By item, By AddtoCart)
        {

            Actions act = new Actions(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            act.ContextClick();

            //Hover over Men tab and click it to access Men menu
            _driver.FindElement(Mens).Click();
            // Click Tops hyperlink to access items
            _driver.FindElement(Tops).Click();
            //Click item
            _driver.FindElement(item).Click();

            //Fail scenario
            try
            {
                //add to cart
                _driver.FindElement(AddtoCart).Click();
            }
            catch (ElementClickInterceptedException)
            {
                return this;
            }
            return this;


        }

        public PageActions Checkout( By newAddress, By street, By city, By zip, By phone, By SaveAdreschkbx,
            By ShipHerebtn, By radio,  By Nextbtn, By radiosameShip,
            By placeOrderbtn, IWebElement stateDropdpwn, string state = "Florida")
            {
            Actions act = new Actions(_driver);
            act.ContextClick();
            Thread.Sleep(3000);
            _driver.FindElement(newAddress).Click();
            _driver.FindElement(street).SendKeys("Street demo");
            _driver.FindElement(city).SendKeys("City demo");
            new SelectElement(stateDropdpwn).SelectByText(state);
            _driver.FindElement(zip).SendKeys("33610");
            _driver.FindElement(phone).SendKeys("123-456-7890");
            _driver.FindElement(SaveAdreschkbx).Click();
            _driver.FindElement(ShipHerebtn).Click();
            Thread.Sleep(3000);
            _driver.FindElement(radio).Click();
            _driver.FindElement(Nextbtn).Click();
            _driver.FindElement(radiosameShip).Click();
            _driver.FindElement(placeOrderbtn).Click();
            return this;


        }

        public PageActions CheckoutFail(By proceedCheckout, By newAddress, By cancel, By ShipHerebtn)
        {
            
            Actions act = new Actions(_driver);
            act.ContextClick();
            _driver.FindElement(proceedCheckout).Click();
            Thread.Sleep(5000);
            _driver.FindElement(newAddress).Click();
            _driver.FindElement(ShipHerebtn).Click();
            _driver.FindElement(cancel).Click();
            return this; //Go to Checkout() after fail
        }

        public void Search()
        {
            PageElements _pageElements = new PageElements(_driver);
            IWebElement element = _driver.FindElement(By.CssSelector("input#search"));
            
            element.SendKeys("pants");
            Thread.Sleep(3000);
            element.SendKeys(Keys.ArrowDown + "" + Keys.Enter);
            Thread.Sleep(3000);

            //validate input
            Assert.IsTrue(_pageElements.productSearch.Displayed);
            
           
            }
           



           
        }

    }

        

