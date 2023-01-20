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
