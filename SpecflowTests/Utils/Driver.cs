using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecflowTests
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get {
                return ConstantsUtils.Url;
            }
        }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
        }

        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        public static void Close() => Instance.Close();



    }

  
}
