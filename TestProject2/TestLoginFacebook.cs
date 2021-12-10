using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TestProject2.Helpers;
using Xunit;

namespace TestProject2
{
    public class TestLoginFacebook
    {
        private ChromeDriver driver;

        public TestLoginFacebook()
        {
            driver = new ChromeDriver(TestHelpers.PastaDoExecutavel());
        }
        [Fact]
        public void DadoChromeAbertoDeveAcessarPaginaFacebookERealizarLogin()
        {
            //Dado que eu acesso a página do facebook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            //Quando eu preecho os campos de login.
           

            driver.FindElement(By.Id("email")).SendKeys("xxxxxxxx@hotmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("xxxxxxxxxxxx");

            //E clico no botão Entrar e capturo o título da página.
            driver.FindElement(By.Name("login")).Click();
            var tituloEsperado = driver.Title;
            var tituloCapturado = "Facebook";

            //Então Capturo o título da página
            Assert.Contains(tituloCapturado, driver.Title);
        }
    }
}
