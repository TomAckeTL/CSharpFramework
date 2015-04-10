using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebdriverSeleniumProject.Navigation
{
    class HomePage
    {
        private string HomePageURI = "https://testroniccafe.be/";
        public HomePage() { }

        public void Navigate(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(HomePageURI);
        }

    }
}
