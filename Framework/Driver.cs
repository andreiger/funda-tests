using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace Framework
{
    public static class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Instantiate()
        {
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            Instance = new ChromeDriver(@"C:\Chrome\", options);
            Instance.Manage().Window.Maximize();
        }

        public static string BaseAddress
        {
            get
            {
                return "https://www.funda.nl/";
            }
        }

        public static void Wait(int timeoutSeconds = 5)
        {
            try { WaitUntil(_ => { return false; }, timeoutSeconds); } catch { }
        }

        public static bool WaitUntil(Func<IWebDriver, bool> condition, int timeoutSeconds = 20)
        {
            WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(timeoutSeconds));
            wait.PollingInterval = TimeSpan.FromSeconds(0.5);
            var result = wait.Until(condition);
            return result;
        }

        public static void Shutdown()
        {
            Instance.Close();
            Instance.Quit();
        }
    }
}