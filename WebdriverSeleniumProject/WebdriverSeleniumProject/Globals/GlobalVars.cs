using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebdriverSeleniumProject.Globals
{
    class GlobalVars
    {
        private IWebDriver globalDriver;

        public GlobalVars() { }

        public IWebDriver GlobalDriver
        {
            get { return globalDriver; }
            set { globalDriver = value; }
        }
    }
}
