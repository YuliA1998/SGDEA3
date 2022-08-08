using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Reflection;
using System.IO;
using SeleniumExtras.WaitHelpers;

namespace Proceso_168016__sgdetest.Hooks
{
    public static class DriverClass
    {
        [Obsolete]
        public static void StartTest(string BaseURL, string Browser)
        {
            try
            {
                if (Browser == "Chrome")
                {
                    //var chromeOptions = new ChromeOptions
                    //{
                    //    BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe",
                    //    //DebuggerAddress = "127.0.0.1:9222"
                    //};

                    //chromeOptions.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" });

                    //var _driver = new ChromeDriver(chromeOptions);
                    ChromeOptions ChromeOptions = new ChromeOptions();
                    //ChromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                    ChromeOptions.AddArguments("disable-blink-features=AutomationControlled");
                    ChromeOptions.AddArguments("--start-maximized");
                    ChromeOptions.AddArguments("--no-sandbox");
                    ChromeOptions.AddArgument("--headless");
                    CustomBaseClass.MyDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ChromeOptions);
                    CustomBaseClass.MyDriver.Navigate().GoToUrl(BaseURL);
                    PageLoaded("userName", "name");
                    Console.WriteLine("Browser loaded, Test Passed");
                }

                if (Browser == "Chrome incognito")
                {
                    ChromeOptions ChromeOptions = new ChromeOptions();
                    //ChromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                    ChromeOptions.AddArguments("incognito");
                    ChromeOptions.AddArguments("--start-maximized");
                    ChromeOptions.AddArguments("--no-sandbox");
                    //ChromeOptions.AddArgument("--headless");
                    CustomBaseClass.MyDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ChromeOptions);
                    CustomBaseClass.MyDriver.Navigate().GoToUrl(BaseURL);
                    PageLoaded("userName", "name");
                    Console.WriteLine("Browser loaded, Test Passed");
                }



            }
            catch (Exception testInitiationException)
            {
                Console.WriteLine("Failed Initiation : {0}", testInitiationException.Message);
                //ScreenShotsClass.FailedTestCaptureScreenShot("Failed Initiation");
                Assert.Fail();
            }
        }

        public static void Createwindow(string BaseURL)
        {

            // Abre una nueva pestaña y cambia el controlador a ella
            WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(30));
            CustomBaseClass.MyDriver.SwitchTo().NewWindow(WindowType.Tab);
            CustomBaseClass.MyDriver.Navigate().GoToUrl(BaseURL);
        }

        public static void CerraPestaña()
        {
            //Almacena el ID de la ventana original
            //string originalWindow = CustomBaseClass.MyDriver.CurrentWindowHandle;


            //Recorrelas hasta encontrar el controlador de la nueva ventana


            //Cambia el controlador a la ventana o pestaña original
            //CustomBaseClass.MyDriver.SwitchTo().Window(originalWindow[1]);
            CustomBaseClass.MyDriver.Close();
            //CustomBaseClass.MyDriver.SwitchTo().Window(originalWindow[0]);







            //Cierra una ventana o pestaña
            //string handles = CustomBaseClass.MyDriver.CurrentWindowHandle;
            //if (handles.Count > 1)
            //{

            //}
            //CustomBaseClass.MyDriver.SwitchTo().Window(handles[1]);
            //CustomBaseClass.MyDriver.Close();
            //CustomBaseClass.MyDriver.SwitchTo().Window(handles[0]);
            //Cambia el controlador a la ventana o pestaña original
            //string originalWindow = CustomBaseClass.MyDriver.CurrentWindowHandle;
            //WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(30));
            //CustomBaseClass.MyDriver.SwitchTo().Window(originalWindow);


        }

        public static void Createwindow2(string BaseURL)
        {


        }




        // This method makes sure the page is fully loaded before test is executed
        [Obsolete]
        public static void PageLoaded(string ObjectId, string finBy)
        {
            try
            {



                if (finBy == "name")
                {
                    WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(15));
                    waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name(ObjectId)));
                }

                if (finBy == "xpath")
                {
                    WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(15));
                    waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath(ObjectId)));
                }
                if (finBy == "id")
                {
                    WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(15));
                    waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id(ObjectId)));
                }
                if (finBy == "link")
                {
                    WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(15));
                    waitForElement.Until(ExpectedConditions.ElementIsVisible(By.LinkText(ObjectId)));
                }
                if (finBy == "css")
                {
                    WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(15));
                    waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(ObjectId)));
                }
                if (finBy == "class")
                {
                    WebDriverWait waitForElement = new WebDriverWait(CustomBaseClass.MyDriver, TimeSpan.FromSeconds(15));
                    waitForElement.Until(ExpectedConditions.ElementIsVisible(By.ClassName(ObjectId)));
                }

            }
            catch (Exception ErrorPageLoad)
            {
                Console.WriteLine("Taking too much time: {0}", ErrorPageLoad.Message);
                // ScreenShots.FailedTestCaptureScreenShot("Load Delay");
                throw ErrorPageLoad;
            }
        }



        // Tears down test and throws exception
        public static void CloseTest()
        {
            try
            {
                CustomBaseClass.MyDriver.Quit();
                //Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

                //foreach (var chromeDriverProcess in chromeDriverProcesses)
                //{
                //    chromeDriverProcess.Kill();
                //}
                Console.WriteLine("Test Completes successfully");
            }
            catch (WebDriverException testClosingException)
            {
                Console.WriteLine("Driver Failed to close the browser: {0}", testClosingException.Message);
            }

        }
    }
}
