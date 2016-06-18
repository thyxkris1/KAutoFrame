using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;


namespace SeleniumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWebDriver wd = new ChromeDriver();
            string targetURL = "http://executeautomation.com/demosite/index.html";
            wd.Url = targetURL;
            wd.Navigate();

            // for drop down list
            SelectElement ddl = new SelectElement(wd.FindElement(By.Id("TitleId")));
            ddl.SelectByText("Ms.");

            //for text box
            IWebElement elementTextBox = wd.FindElement(By.Id("Initial"));
            elementTextBox.SendKeys("Kris");

            //Radio button
            IWebElement elementRadioButton = wd.FindElement(By.CssSelector("input[value = 'female']"));
            elementRadioButton.Click();

            //Checked box
            IWebElement elementCheckBox = wd.FindElement(By.CssSelector("input[name = 'Hindi']"));
            elementCheckBox.Click();

           // #Selenium\ WebDriver

            //IWebElement elementJavascript = wd.FindElement(By.CssSelector("span[id = 'Selenium WebDriver']"));
            //elementJavascript.Click();
            Actions builder = new Actions(wd);
            IAction mouseOver = builder.MoveToElement(wd.FindElement(By.CssSelector("span[id = 'Automation Tools']"))).MoveToElement(wd.FindElement(By.CssSelector("span[id = 'Selenium']"))).MoveToElement(wd.FindElement(By.CssSelector("span[id = 'Selenium WebDriver']"))).Click().Build();

            mouseOver.Perform();

            // save
            IWebElement elementSaveButton = wd.FindElement(By.Name("Save"));
            elementSaveButton.Click();







        }
    }
}
