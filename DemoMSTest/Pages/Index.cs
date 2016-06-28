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
using System.Globalization;
using OpenQA.Selenium.Support.UI;

namespace DemoMSTest.Pages
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
        public SelectElement SelectTitleId { get; set; }
        
        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        public void GoToUrl()
        {
            var url = KAutoFrame.Config.ConfigReader.GetUrlValue;
            this.DriverContext.Driver.Navigate().GoToUrl(url.ToString());
            Logger.Info(CultureInfo.CurrentCulture, "Opening page {0}", url);

            SelectTitleId = new SelectElement(ddlTitleId);
        }

        
        
    }
}
