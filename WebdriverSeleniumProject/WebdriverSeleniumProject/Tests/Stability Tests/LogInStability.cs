using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using WebdriverSeleniumProject.HelperClasses;

namespace WebdriverSeleniumProject.Tests.Stability_Tests
{
    class LogInStability
    {
        private IWebDriver driver;
        private int i = 0;
        private Data data = new Data();
        private SeleniumCommands commander;


        public LogInStability() {}

        public void LogOnRepeat(IWebDriver MainDriver)
        {
            commander = new SeleniumCommands(MainDriver);
            for (int k = i; k < data.counter; k++)
            //foreach (string l in Users)
            {
                driver = MainDriver;
                //IWebElement userName;
                //IWebElement userPassword;
                try
                {
                    //This 'for' loop makes sure the login page is fully loaded before searching the user name
                    WaitForElement("username_field");
                    //Thread.Sleep(5000);

                    commander.EnterCredential("username_field", data.Users[i]);
                    //Find the Password input field and fill in the password
                    commander.EnterCredential("password_field", data.Passwords[i]);
                    commander.SubmitCredential("password_field");
                    Thread.Sleep(3000);

                    try
                    {
                        IWebElement Age = driver.FindElement(By.Id(data.gen("age_submit_button")));
                        Age.Click();
                        Thread.Sleep(1000);
                    }
                    catch { }

                    Logout(driver);
                    Thread.Sleep(2000);
                }

                catch
                {
                    i++;
                    LogOnRepeat(driver);
                }
                i++;
            }
        }


        public void Logout(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//li[3]/a/span")).Click();
            driver.FindElement(By.XPath("//li[3]/ul/li[3]/a/span")).Click();
        }

        public void WaitForElement(string element)
        {

            for (int second = 0; second < 61; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {

                    if (IsElementPresent(By.Id(data.gen(element)))) break;

                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }

        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
