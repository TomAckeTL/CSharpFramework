using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebdriverSeleniumProject.Globals;

namespace WebdriverSeleniumProject
{
    class RemoteWebDriverProperties
    {
        //private IWebDriver driver;
        private string URI = "http://10.154.1.49:4444/wd/hub"; //Server-IP
        private GlobalVars driver = new GlobalVars();
        public RemoteWebDriverProperties() { }


        public IWebDriver Initialize(Type type)
        {
            
            if (type == typeof(InternetExplorerDriver))
            {
                DesiredCapabilities dc = new DesiredCapabilities();
                dc = DesiredCapabilities.InternetExplorer();
                dc.SetCapability(CapabilityType.BrowserName, "iexplore");
                driver.GlobalDriver = new RemoteWebDriver(new Uri(URI), dc);
            }
            if (type == typeof(ChromeDriver))
            {
                driver.GlobalDriver = new RemoteWebDriver(new Uri(URI), DesiredCapabilities.Chrome());
            }
            if (type == typeof(FirefoxDriver))
            {
                driver.GlobalDriver = new RemoteWebDriver(new Uri(URI), DesiredCapabilities.Firefox());
            }
            if (type == typeof(OperaDriver))
            {
                driver.GlobalDriver = new RemoteWebDriver(new Uri(URI), DesiredCapabilities.Opera());
            }
            if (type == typeof(SafariDriver))
            {
                driver.GlobalDriver = new RemoteWebDriver(new Uri(URI), DesiredCapabilities.Safari());
            }
            return driver.GlobalDriver;
        }
    }
}
