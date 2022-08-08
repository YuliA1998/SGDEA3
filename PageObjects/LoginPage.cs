using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Proceso_168016__sgdetest.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement linkLogin => driver.FindElement(By.XPath("//a[text()='Login']"));
        public IWebElement textUsername => driver.FindElement(By.Name("userName"));
        public IWebElement textPassword => driver.FindElement(By.XPath("/html[1]/body[1]/oph-root[1]/oph-login-page[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/dx-form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/dx-text-box[1]/div[1]/div[1]/input[1]"));
        public IWebElement buttonLogin => driver.FindElement(By.XPath("//div[@aria-label='Iniciar sesión']//div[@class='dx-button-content']"));
        public IWebElement linkForgotPassword => driver.FindElement(By.XPath("//span[text()='Forgot?']"));
        public IWebElement buttonLogout => driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
        public IWebElement errorMessage => driver.FindElement(By.XPath("//span[contains(text(),'Your username or password is incorrect')]"));


    }
}
