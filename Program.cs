using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //IWebDriver webDriver = new FirefoxDriver();
            //webDriver.Navigate().GoToUrl("https://www.saucedemo.com");
            //webDriver.Manage().Window.Maximize();

            ////click element
            //By loginBtn = By.CssSelector("#login-button");
            //webDriver.FindElement(loginBtn).Click();

            ////send keys
            //webDriver.FindElement(By.Id("user-name")).SendKeys("standard_user");

            //webDriver.FindElement(By.Id("user-name")).Clear();

            //var isDisplayed = webDriver.FindElement(By.Id("login-button")).Displayed;
            //Console.WriteLine($"is displayed: {isDisplayed}");

            //var isEnabled = webDriver.FindElement(By.Id("login-button")).Enabled;
            //Console.WriteLine($"is enabled: {isEnabled}");

            //var cssValue = webDriver.FindElement(By.Id("login-button")).GetCssValue("color");
            //Console.WriteLine($"color: {cssValue}");

            //var text = webDriver.FindElement(By.CssSelector("div>h3")).Text;
            //Console.WriteLine($"button text: {text}");

            //webDriver.Quit();

            //////////////////////////////////////////////////////////////////////////////////////////////
            //void fckCaptcha()
            //{
            //    Thread.Sleep(2000);
            //}


            //IWebDriver webDriver = new FirefoxDriver();
            //webDriver.Manage().Window.Maximize();
            //webDriver.Navigate().GoToUrl("https://www.expedia.com");

            ////czeka na załadowanie się strony
            //IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(6.00));
            //wait.Until(driver1 => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));

            ////zamyka pop-up
            //webDriver.FindElement(By.CssSelector("#wizardMainRegionV2")).Click();
            //fckCaptcha();

            ////podstrona lotów
            //webDriver.FindElement(By.XPath("//a[@href='?pwaLob=wizard-flight-pwa']")).Click();
            //fckCaptcha();

            ////skąd lecimy
            //webDriver.FindElement(By.CssSelector("#location-field-leg1-origin-menu")).Click();
            //fckCaptcha();
            //By departure = By.CssSelector("#location-field-leg1-origin");
            //webDriver.FindElement(departure).SendKeys("Warsaw (WAW - Frederic Chopin)");
            //fckCaptcha();
            //webDriver.FindElement(departure).SendKeys(Keys.Enter);
            //fckCaptcha();

            ////cel podróży
            //webDriver.FindElement(By.CssSelector("#location-field-leg1-destination-menu")).Click();
            //fckCaptcha();
            //By destination = By.CssSelector("#location-field-leg1-destination");
            //webDriver.FindElement(destination).SendKeys("Sapporo (CTS - New Chitose)");
            //fckCaptcha();
            //webDriver.FindElement(destination).SendKeys(Keys.Enter);
            //fckCaptcha();

            ////data wylotu
            //webDriver.FindElement(By.CssSelector("#d1-btn")).Click();
            //fckCaptcha();
            //webDriver.FindElement(By.XPath("(//button[@class='uitk-date-picker-day'])[20]")).Click();
            //fckCaptcha();
            //webDriver.FindElement(By.XPath("(//button[@class='uitk-button uitk-button-medium uitk-button-has-text uitk-button-primary'])")).Click();
            //fckCaptcha();

            ////powrót
            //webDriver.FindElement(By.CssSelector("#d2-btn")).Click();
            //fckCaptcha();
            //webDriver.FindElement(By.XPath("(//button[@class='uitk-date-picker-day'])[27]")).Click();
            //fckCaptcha();
            //webDriver.FindElement(By.XPath("(//button[@class='uitk-button uitk-button-medium uitk-button-has-text uitk-button-primary'])")).Click();
            //fckCaptcha();

            ////liczba osób itd
            //webDriver.FindElement(By.CssSelector("#adaptive-menu")).Click();
            //fckCaptcha();

            //webDriver.FindElement(By.XPath("(//span[@class='uitk-step-input-button'])[4]")).Click();
            //fckCaptcha();
            //webDriver.FindElement(By.CssSelector("#child-age-input-0-0")).SendKeys("4");
            //fckCaptcha();

            //webDriver.FindElement(By.XPath("(//span[@class='uitk-step-input-button'])[6]")).Click();
            //fckCaptcha();
            //webDriver.FindElement(By.CssSelector("#infant-age-input-0-0")).SendKeys("1");
            //fckCaptcha();

            //webDriver.FindElement(By.CssSelector("#ChildInSeat")).Click();
            //fckCaptcha();

            //webDriver.FindElement(By.XPath("(//button[@class='uitk-button uitk-button-large uitk-button-fullWidth uitk-button-has-text uitk-button-primary uitk-button-floating-full-width'])")).Click();
            //fckCaptcha();

            ////klasa
            //webDriver.FindElement(By.CssSelector("#preferred-class-input-trigger")).Click();
            //fckCaptcha();
            //webDriver.FindElement(By.XPath("(//a[@class='uitk-list-item'])[3]")).Click();
            //fckCaptcha();

            ////użyj opcji szukaj
            //webDriver.FindElement(By.XPath("(//button[@class='uitk-button uitk-button-large uitk-button-fullWidth uitk-button-has-text uitk-button-primary'])")).Click();

            //webDriver.Quit();

            //==============================================================================================================
            IWebDriver webDriver = new FirefoxDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com");

            webDriver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            webDriver.FindElement(By.Id("password")).SendKeys("secret_sauce");

            webDriver.FindElement(By.CssSelector("#login-button")).Click();

            webDriver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack")).Click();

            webDriver.FindElement(By.CssSelector("#shopping_cart_container")).Click();

            var qnt = webDriver.FindElement(By.CssSelector(".cart_quantity")).Text;
            Console.WriteLine($"Quantity: {qnt}");
            Assert.IsTrue(qnt == "1");
            
            var name = webDriver.FindElement(By.CssSelector(".inventory_item_name")).Text;
            Console.WriteLine($"Product name: {name}");
            Assert.IsTrue(name == "Sauce Labs Backpack");

            var price = webDriver.FindElement(By.CssSelector(".inventory_item_price")).Text;
            Console.WriteLine($"Price: {price}");
            Assert.AreEqual(price, "$29.99");

            webDriver.Quit();
        }
    }
}
