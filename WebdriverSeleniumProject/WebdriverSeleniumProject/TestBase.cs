using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using WebdriverSeleniumProject;
using WebdriverSeleniumProject.Navigation;
using WebdriverSeleniumProject.UserActions;
using OpenQA.Selenium.Safari;
using System.Threading;
using WebdriverSeleniumProject.Tests.Stability_Tests;
using WebdriverSeleniumProject.Globals;

namespace WebdriverSeleniumProject
{

    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(InternetExplorerDriver))]
    //[TestFixture(typeof(OperaDriver))]
    //[TestFixture(typeof(SafariDriver))]
    public class TestBase<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        //private IWebDriver driver;
        private RemoteWebDriverProperties prop = new RemoteWebDriverProperties();
        private Pages pages = new Pages();
        private GlobalVars driver = new GlobalVars();



        [SetUp]
        public void Init()
        {
            driver.GlobalDriver = prop.Initialize(typeof(TWebDriver));
            driver.GlobalDriver.Manage().Window.Maximize();
        }

        [Test]
        public void LogInStability()
        {
            LogInStability logon = new LogInStability();

            pages.home.Navigate(driver.GlobalDriver);

            logon.LogOnRepeat(driver.GlobalDriver);

            Thread.Sleep(2000);
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            if (driver != null)
            {
                driver.GlobalDriver.Close();
                driver.GlobalDriver.Quit();
                driver.GlobalDriver.Dispose();
            }
        }

    }
}
