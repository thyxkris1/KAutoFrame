using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KAutoFrame.Base;
using KAutoFrame.Extensions;
using DemoMSTest.Pages;
using OpenQA.Selenium.Support.UI;

namespace DemoMSTest
{
    [TestClass]
    public class UnitTest1 :Base
    {
        [TestMethod]
        public void TestMethod1()
        {
            Index indexPage = new Index(this.DriverContext);
            indexPage.GoToUrl();
            this.DriverContext.Driver.WaiFor(100000);
            indexPage.SelectTitleId.SelectByText("Ms.");
            indexPage.txtInitial.SendKeys("kris");
            indexPage.txtFirstName.SendKeys("ma");
            indexPage.btnSave.Click();

            
        }
    }
}
