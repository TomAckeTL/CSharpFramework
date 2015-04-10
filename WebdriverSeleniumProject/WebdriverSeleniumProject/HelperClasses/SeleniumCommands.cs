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


        public SeleniumCommands()
        {


        }

        public SeleniumCommands(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void EnterCredential(string field, string keys)
        {
            IWebElement tbox = driver.FindElement(By.Id(data.gen(field)));
            tbox.Clear();
            tbox.SendKeys(keys);
        }

        public void SubmitCredential(string field)
        {
            IWebElement tbox = driver.FindElement(By.Id(data.gen(field)));
            tbox.Submit();
        }






    }
}
