using System;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver1.Configuration;
using SeleniumWebDriver1.Interfaces;

namespace SeleniumWebDriver1
{
    [TestFixture]
    public class ReadFromAppConfig
    {
        [Test]
        public void Test1()
        {
            //якщо потрібно буде витягнути дані з XML то я просто створю собі метод XMLReader, 
            // який буде створений на основі мого інтерфейсу IConfig, тут я просто створю собі його 
            // об'єкт і всі дані підтягнуться з іншого джерела
            IConfig config = new AppConfigReader();
            Console.WriteLine("Browser: {0}",config.GetBrowser() );
            Console.WriteLine("Username: {0}",config.GetUsername() );
            Console.WriteLine("Password: {0}",config.GetPassword() );
        }
    }
}