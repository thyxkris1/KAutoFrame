using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
namespace AppiumTest
{
    [TestClass]
    public class UnitTest1
    {
        AppiumDriver<IWebElement> driver;
        [TestMethod]
        public void TestMethod1()
        {
            //DesiredCapabilities cap = new DesiredCapabilities();
            //cap.SetCapability("deviceName", "donatello");
            //cap.SetCapability("appActivity", "com.example.calculator");



            ////Launch the Android driver
            //driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);


            //Assert.IsNull(driver.Context);
        }
    }
}
