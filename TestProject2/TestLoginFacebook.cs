using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TestProject2.Fixtures;
using TestProject2.Helpers;
using Xunit;

namespace TestProject2
{
    public class TestLoginFacebook : IClassFixture<TestFixture>
    {
        private IWebDriver driver;

        public TestLoginFacebook(TestFixture fixture)
        {
            driver = fixture.Driver;
        }
        [Fact]
        public void DadoChromeAbertoDeveAcessarPaginaFacebookERealizarLogin()
        {
            // Dado que eu acesso a p�gina do facebook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Quando eu preecho os campos de login.
            driver.FindElement(By.Id("email")).SendKeys("xxxxxxxx@hotmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("xxxxxxxxxxxx");

            // E clico no bot�o Entrar e capturo o t�tulo da p�gina.
            driver.FindElement(By.Name("login")).Click();
            var tituloEsperado = driver.Title;
            var tituloCapturado = "Facebook";

            // Ent�o Capturo o t�tulo da p�gina
            Assert.Contains(tituloCapturado, tituloEsperado);
        }
    }
}
