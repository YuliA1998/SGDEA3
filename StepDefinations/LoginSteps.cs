using Proceso_168016__sgdetest.Hooks;
using Proceso_168016__sgdetest.PageObjects;
using Proceso_168016__sgdetest.TestData;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;


namespace Proceso_168016__sgdetest.StepDefinations
{
    [Binding]
    public class LoginExternalSiteSteps
    {

        static String JsonGlobal;

        [Given(@"Usurio navega en el inicio de  (.*)  sesion (.*)")]
        [Obsolete]
        public void GivenUserNavigatesToApplicationLoginPage(String site, String Navegador)
        {
            try
            {
                DriverClass.StartTest(TestConfig.internalUrl, TestConfig.Navegador);
                //LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                FindElemenstClass findElemenstClass = new FindElemenstClass(CustomBaseClass.MyDriver);
                //Comment for Applications where default page is Login
                //loginPage.linkLogin.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not load the application : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }


        [Given(@"Cargo el  DOM de la app: (.*)")]
        public void GivenCargoElDOMDeLaAppInisioSesion(string FileName)
        {
            JsonClass json = new JsonClass(TestConfig.BaseDir);
            JsonGlobal = JsonClass.ReadJson(FileName);

        }

        [When(@"Click en el (.*)")]
        public void WhenClickEnElBoton(string elemvalue)
        {
            EntityClass elem = JsonClass.Get_entity(elemvalue);
            var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
            elementoo.Click();


        }

        [When(@"Usuario se logea con credenciale (.*) y (.*) en los campos (.*) y (.*)")]
        public void WhenUserLoginUsingCredentialsAnd(string username, string passwordType, string uservaluefind, string passvaluefind)
        {
            //LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
            CustomBaseClass.MyDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            EntityClass usr = JsonClass.Get_entity(uservaluefind);
            EntityClass pass = JsonClass.Get_entity(passvaluefind);
            var usernameText = FindElemenstClass.GetElement(usr.GetFieldBy, usr.ValueToFind);
            var passwordTypeText = FindElemenstClass.GetElement(pass.GetFieldBy, pass.ValueToFind);

            CustomBaseClass.EnterText(usernameText, username);
            if (passwordType.Contains("validPassword"))
            {
                CustomBaseClass.EnterText(passwordTypeText, TestConfig.validPassword);
            }
            else
            {
                CustomBaseClass.EnterText(passwordTypeText, TestConfig.invalidPassword);
            }
            //loginPage.buttonLogin.Click();            
        }

        [Then(@"User should be able to login succesfully (.*)")]
        public void ThenUserShouldBeAbleToLoginSuccesfully(String firstName)
        {
            try
            {
                CustomBaseClass.Thinktime(15);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(CustomBaseClass.MyDriver.FindElement(By.XPath("//div[contains(text(),'" + firstName + "')]")));


            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not login to the application : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }

        }


        [Then(@"Test completed Successfully")]
        public void ThenTestCompletedSuccessfully()
        {
            DriverClass.CloseTest();
        }

        [Then(@"Then User should get (.*) message")]
        public void ThenThenUserShouldGet(String errorMessage)
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                // AssertClass.ContainsText(loginPage.errorMessage, errorMessage);
                AssertClass.AssertElementIsPresent(loginPage.errorMessage);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not verify error message: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [When(@"User click on Logout link")]
        public void WhenUserClickOnLogoutLink()
        {
            LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
            loginPage.buttonLogout.Click();
        }

        [Then(@"User should be redirected to Login Page")]
        public void ThenUserShouldBeRedirectedToLoginPage()
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.buttonLogin);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not logout : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"User should be able to validate forgot password link")]
        public void ThenUserShouldBeAbleToValidateForgotPasswordLink()
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.linkForgotPassword);
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not validate : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }



    }
}
