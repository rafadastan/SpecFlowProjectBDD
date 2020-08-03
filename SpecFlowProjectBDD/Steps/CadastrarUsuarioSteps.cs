using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDD.Steps
{
    [Binding]
    public class CadastrarUsuarioSteps
    {
        //atributo
        private IWebDriver webDriver;

        [Given(@"Acessar a página de cadastro de conta de usuário")]
        public void DadoAcessarAPaginaDeCadastroDeContaDeUsuario()
        {
            //abrir o googlechrome
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            //acessar a página de cadastro de conta de usuário
            webDriver.Navigate().GoToUrl("https://lojaexemplod.lojablindada.com/customer/account/create/");
        }

        [Given(@"Informar o nome ""(.*)""")]
        public void DadoInformarONome(string nome)
        {
            //preencher o campo do formulário
            var element = webDriver.FindElement(By.CssSelector("#firstname"));
            element.Clear(); //limpar o conteudo do campo
            element.SendKeys(nome); //preenchendo o campo
        }

        [Given(@"Informar o sobrenome ""(.*)""")]
        public void DadoInformarOSobrenome(string sobrenome)
        {
            //preencher o campo do formulário
            var element = webDriver.FindElement(By.CssSelector("#lastname"));
            element.Clear(); //limpar o conteudo do campo
            element.SendKeys(sobrenome); //preenchendo o campo
        }

        [Given(@"Informar o email ""(.*)""")]
        public void DadoInformarOEmail(string email)
        {
            //preencher o campo do formulário
            var element = webDriver.FindElement(By.CssSelector("#email_address"));
            element.Clear(); //limpar o conteudo do campo
            element.SendKeys(email); //preenchendo o campo
        }

        [Given(@"Informar a senha ""(.*)""")]
        public void DadoInformarASenha(string senha)
        {
            //preencher o campo do formulário
            var element = webDriver.FindElement(By.CssSelector("#password"));
            element.Clear(); //limpar o conteudo do campo
            element.SendKeys(senha); //preenchendo o campo
        }

        [Given(@"Confirmar a senha ""(.*)""")]
        public void DadoConfirmarASenha(string senha)
        {
            //preencher o campo do formulário
            var element = webDriver.FindElement(By.CssSelector("#confirmation"));
            element.Clear(); //limpar o conteudo do campo
            element.SendKeys(senha); //preenchendo o campo
        }

        [When(@"Executar o cadastro do usuário")]
        public void QuandoExecutarOCadastroDoUsuario()
        {
            //clicar no botão
            var element = webDriver.FindElement(By.CssSelector("#form-validate > div.buttons-set > button"));
            if (element.Displayed && element.Enabled)
                element.Click();
        }

        [Then(@"Sistema exibe a mensagem ""(.*)""")]
        public void EntaoSistemaExibeAMensagem(string mensagem)
        {
            var element = webDriver.FindElement(By.CssSelector("body > div > div > div.main-container.col2-left-layout > div > div.col-main > div > div > ul > li > ul > li > span"));
            Assert.AreEqual(mensagem, element.Text);

            webDriver.Close();
            webDriver.Quit();
        }

    }
}
