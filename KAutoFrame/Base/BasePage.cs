using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KAutoFrame.Extensions;
using KAutoFrame.Helpers;
using KAutoFrame.Config;
using OpenQA.Selenium;

namespace KAutoFrame.Base
{
    public class BasePage // for POM
    {
        public BasePage(DriverContext driverContext)
        {
            this.DriverContext = driverContext;
            this.Driver = driverContext.Driver;
        }

        protected IWebDriver Driver { get; set; }

        protected DriverContext DriverContext { get; set; }
    }
}
