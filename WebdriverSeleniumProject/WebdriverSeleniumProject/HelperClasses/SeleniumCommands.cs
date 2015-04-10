using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebdriverSeleniumProject.HelperClasses
{
    class SeleniumCommands
    {
        private IWebDriver driver;
        private Data data = new Data();



        public SeleniumCommands(IWebDriver driver)
        {
            this.driver = driver;

        }
    }
}
