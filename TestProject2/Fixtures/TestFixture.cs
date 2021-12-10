using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject2.Helpers;

namespace TestProject2.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelpers.PastaDoExecutavel());
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
