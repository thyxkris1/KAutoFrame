using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Microsoft.VisualStudio.TestTools.UnitTesting;
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
     [TestClass]
    /// <summary>
    /// The base class for all tests
    /// </summary>
    public class Base //不用很复杂，写成一个就可以，毕竟不是针对多个不同的测试框架（只有Nunit，MSTest）
    {
         private readonly DriverContext driverContext = new DriverContext();

         /// <summary>
         /// Gets the driver context
         /// </summary>
         protected DriverContext DriverContext
         {
             get
             {
                 return this.driverContext;
             }
         }
         /// <summary>
         /// Gets or sets logger instance for driver
         /// </summary>
         public KAutoFrame.Helpers.LogHelpers LogHelpersTestLogTest
         {
             get
             {
                 return this.DriverContext.logHelpersTestLogTest;
             }

             set
             {
                 this.DriverContext.logHelpersTestLogTest = value;
             }
         }

         /// <summary>
         /// Gets or sets the microsoft test context.
         /// </summary>
         /// <value>
         /// The microsoft test context.
         /// </value>
         public TestContext TestContext { get; set; }

         /// <summary>
         /// Before the test.
         /// </summary>
         [TestInitialize]
         public void BeforeTest()
         {
             this.DriverContext.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
             this.DriverContext.TestTitle = this.TestContext.TestName;
             this.LogHelpersTestLogTest.LogTestStarting(this.driverContext);
             this.DriverContext.Start(); //真正的初始化在这里
         }

         /// <summary>
         /// After the test.
         /// </summary>
         [TestCleanup]
         public void AfterTest()
         {

             this.DriverContext.Stop();
             this.LogHelpersTestLogTest.LogTestEnding(this.driverContext);

         }
    }
}
