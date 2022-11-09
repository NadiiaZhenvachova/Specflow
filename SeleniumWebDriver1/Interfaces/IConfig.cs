using SeleniumWebDriver1.Configuration;

namespace SeleniumWebDriver1.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();
    }
}