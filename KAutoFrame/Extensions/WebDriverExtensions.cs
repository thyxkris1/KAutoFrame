using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using OpenQA.Selenium; 
namespace KAutoFrame.Extensions
{
     
    public static class WebDriverExtensions
    {
       
        public static void WaiFor(this IWebDriver driver, int timeOut)
        {
            Thread.Sleep(timeOut);
        }
        
    }
}
