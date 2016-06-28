using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using KAutoFrame.Base;
using KAutoFrame.Helpers;
using KAutoFrame.Extensions;
using System.Configuration;
using System.Collections.Specialized;
using KAutoFrame.Config;

namespace KAutoFrame.Base
{
    /// <summary>
    /// Contains handle to driver and methods for web browser
    /// </summary>
    public class DriverContext
    {

        /// <summary>
        /// Gets driver Handle
        /// </summary>
        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }

       
        public bool IsTestFailed { get; set; }

        /// <summary>
        /// Gets or sets the test title.
        /// </summary>
        /// <value>
        /// The test title.
        /// </value>
        public string TestTitle { get; set; }

        /// <summary>
        /// Gets or sets directory where assembly files are located
        /// </summary>
        public string CurrentDirectory { get; set; }
        /// <summary>
        /// Gets or sets test logger
        /// </summary>
        public LogHelpers logHelpersTestLogTest
        {
            get
            {
                return this.logHelpersTest ?? (this.logHelpersTest = new LogHelpers());
            }

            set
            {
                this.logHelpersTest = value;
            }
        }

        private IWebDriver driver;
        private LogHelpers logHelpersTest;

        private FirefoxProfile FirefoxProfile;// will be finished later
        
        private ChromeOptions ChromeProfile
        {
            get
            {
                ChromeOptions options = new ChromeOptions();

                //// retrieving settings from config file, also need to manually add dll, in the references
                //var chromePreferences = ConfigurationManager.GetSection("ChromePreferences") as NameValueCollection;
                //var chromeExtensions = ConfigurationManager.GetSection("ChromeExtensions") as NameValueCollection;
               
                  

                // set browser proxy for chrome
 

                // custom preferences
                


                return options;
            }
        }

        /// <summary>
        /// Starts the specified Driver.
        /// </summary>
        /// <exception cref="NotSupportedException">When driver not supported</exception>
         public void Start() // initialization is here
        {
            switch (ConfigReader.TestBrowser)
            {
                case ConfigReader.BrowserType.Firefox:
                    this.driver = new FirefoxDriver(new FirefoxBinary(ConfigReader.FirefoxPath), this.FirefoxProfile);
                    break;
                case ConfigReader.BrowserType.FirefoxPortable:
                    var profile = this.FirefoxProfile;
                    var firefoxBinary = new FirefoxBinary(ConfigReader.FirefoxPath);
                    this.driver = new FirefoxDriver(firefoxBinary, profile);
                    break;
                //case BrowserType.InternetExplorer:
                //    this.driver = new InternetExplorerDriver(this.InternetExplorerProfile);
                //    break;
                case ConfigReader.BrowserType.Chrome:
                    this.driver = new ChromeDriver(this.ChromeProfile);
                    break;
                default:
                    throw new NotSupportedException(
                        string.Format(System.Globalization.CultureInfo.CurrentCulture, "Driver {0} is not supported", ConfigReader.TestBrowser));
            }

            //this.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(ConfigReader.LongTimeout));
            //this.driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(ConfigReader.ShortTimeout));
            //this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(ConfigReader.ImplicitlyWaitMilliseconds));
            this.driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Stop browser instance.
        /// </summary>
        public void Stop()
        {
            this.driver.Quit();
        }

    }
}
