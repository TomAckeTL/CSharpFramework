using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WebdriverSeleniumProject.UserActions
{
    class LogOnUser
    {

        public LogOnUser()
        {

        }

        public void LogOn (IWebDriver driver){

            //Find the Username input field and fill in the username
            IWebElement userName = driver.FindElement(By.Id("name"));
            userName.SendKeys("WsTester1");

            //Find the Password input field and fill in the password
            IWebElement userPassword = driver.FindElement(By.Id("pass"));
            userPassword.SendKeys("password");

            userPassword.Submit();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//li[3]/a/span")).Click();
            driver.FindElement(By.XPath("//li[3]/ul/li[2]/a/span")).Click();


        }


    }
}
