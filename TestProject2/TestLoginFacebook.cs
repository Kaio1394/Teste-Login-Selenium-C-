using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace TestProject2
{
    public class TestLoginFacebook
    {
        [Fact]
        public void DadoChromeAbertoDeveAcessarPaginaFacebookERealizarLogin()
        {
            //Dado que eu acesso a p�gina do facebook
            IWebDriver driver = 
                new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Navigate().GoToUrl("https://www.facebook.com");

            //Quando eu preecho dos campso de login.
            driver.FindElement(By.Id("email")).SendKeys("xxxxxxxx@hotmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("xxxxxxxxxxxx");
            
            //E clico no bot�o Entrar.
            driver.FindElement(By.Name("login")).Click();

            //Ent�o Capturo o t�tulo da p�gina
            var tituloEsperado = driver.Title;
            var tituloCapturado = "Facebook";

            Assert.Contains(tituloCapturado, driver.Title);
        }
    }
}
