using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Globalization;

namespace KAutoFrame.Config
{
    /// <summary>
    /// SeleniumConfiguration that consume app.config file
    /// </summary>
    /// 
    public static  class ConfigReader
    {


        /// 
        /// <summary>
        /// Supported browsers
        /// </summary>
        public enum BrowserType
        {
            /// <summary>
            /// Firefox browser
            /// </summary>
            Firefox,

            /// <summary>
            /// Firefox portable
            /// </summary>
            FirefoxPortable,

            /// <summary>
            /// InternetExplorer browser
            /// </summary>
            InternetExplorer,

            /// <summary>
            /// Chrome browser
            /// </summary>
            Chrome,

            /// <summary>
            /// Not supported browser
            /// </summary>
            None
        }
        /// <summary>
        /// Gets the Driver.
        /// </summary>
        public static BrowserType TestBrowser
        {
            get
            {
                BrowserType browserType;
                
                bool supportedBrowser = Enum.TryParse(ConfigurationManager.AppSettings["browser"], out browserType);

                if (supportedBrowser)
                {
                    return browserType;
                }

                return BrowserType.None;
            }
        }
        public static string Protocol
        {
            get { return ConfigurationManager.AppSettings["protocol"]; }
        }

        /// <summary>
        /// Gets the application host name.
        /// </summary>
        public static string Host
        {
            get { return ConfigurationManager.AppSettings["host"]; }
        }

        /// <summary>
        /// Gets the url.
        /// </summary>
        public static string Url
        {
            get { return ConfigurationManager.AppSettings["url"]; }
        }
        /// <summary>
        /// Gets the firefox path
        /// </summary>
        public static string FirefoxPath
        {
            get
            {
                return ConfigurationManager.AppSettings["FireFoxPath"];
            }
        }


        /// <summary>
        /// Gets the URL value 'Protocol://HostURL'.
        /// </summary>
        public static string GetUrlValue
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture, "{0}://{1}{2}", Protocol, Host, Url);
            }
        }
    }
}
