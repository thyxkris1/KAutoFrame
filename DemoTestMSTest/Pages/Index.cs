using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KAutoFrame;
using KAutoFrame.Base;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoTestMSTest.Pages
{
    public class Index : BasePage
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public Index(DriverContext driverContext)
            : base(driverContext)
        {
            PageFactory.InitElements(this.DriverContext.Driver, this); 
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        private IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        private IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        private IWebElement btnSave { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        private IWebElement txtFirstName { get; set; }
        
    }
}
