using OpenQA.Selenium;
using SeleniumWebDriver1.Interfaces;

namespace SeleniumWebDriver1.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}