using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TestProject2.Helpers
{
    public class TestHelpers
    {
        public static string PastaDoExecutavel()
        {
            var driver = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return driver;
        }
        public static void AcessarPaginaFaceook()
        {
            IWebDriver driver = new ChromeDriver(PastaDoExecutavel());
            driver.Navigate().GoToUrl("https://www.facebook.com");
        }
    }
}
