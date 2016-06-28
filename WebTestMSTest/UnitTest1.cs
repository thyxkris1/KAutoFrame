using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text;
using System.Threading;

namespace WebTestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver md = new ChromeDriver();

            StringBuilder Url = new StringBuilder("http://www.google.com");
            md.Navigate().GoToUrl(Url.ToString());


            md.FindElement(By.ClassName("gsfi")).SendKeys("ExecutionAutomation");
           // md.FindElement(By.Name("btnK")).Click();

            Thread.Sleep(10000);

            
            IWebElement we = md.FindElement(By.PartialLinkText("Execute Automation – Automation Testing Automated (1.5 million"));

            we.Click();
            string actualResult = "Execute Automation – Automation Testing Automated (1.5 million view)";

            Assert.AreEqual(actualResult,md.Title.ToString());

            md.Quit();



        }


        [TestMethod]
        public void FindWebsite()
        {

        }
    }
}
