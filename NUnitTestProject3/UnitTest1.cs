using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace NUnitTestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver(@"C:\Testing");
            webDriver.Navigate().GoToUrl(@"C:\Testing\Hivatalosdoga.html");
            webDriver.FindElement(By.Id(""));
            webDriver.FindElement(By.LinkText("DevOps1")).Click();
            string oldal = webDriver.Url;
            webDriver.Navigate().GoToUrl(@"C:\Testing\Hivatalosdoga.html");
            // ezt nem tudom megoldani :D webDriver.FindElement(By.XPath("select[@name= visitor[a]"));
            webDriver.FindElement(By.Id("checkbox_car")).Click();
            if (webDriver.FindElement(By.Id("checkbox_car")).Selected==true)
            {
                Assert.Pass();
            }
            
            webDriver.FindElement(By.Id("radio_kivalo")).Click();
            if (webDriver.FindElement(By.Id("radio_jeles")).Selected == false)
            {
                Assert.Pass();
            }

            webDriver.FindElement(By.XPath("button[@onclick =cimvalto()")).Click();
            var images = webDriver.FindElement(By.TagName("img"));
            



            
        }
    }
}