using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace SeleniumWebDriver1.BaseClass
{
   
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
        
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        
        private static IWebDriver GetSafariDriver()
        {
            IWebDriver driver = new SafariDriver();
            return driver;
        }
        
       [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            
        }
    }
}