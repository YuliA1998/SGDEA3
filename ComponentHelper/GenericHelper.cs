using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Proceso_168016__sgdetest.Hooks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Proceso_168016__sgdetest.ComponentHelper
{
    public class GenericHelper
    {

        private static Func<IWebDriver, bool> WaitForWebElementFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return true;

                return false;
            });
        }

        private static Func<IWebDriver, IList<IWebElement>> GetAllElements(By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator);
            });
        }

        private static Func<IWebDriver, IWebElement> WaitForWebElementInPageFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return x.FindElement(locator);
                return null;
            });
        }



        public static void TakeScreenShot(string filename = "Screen")
        {
            var screen = CustomBaseClass.MyDriver.TakeScreenshot();
            if (filename.Equals("Screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);

                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);

        }

        public static void TakeScreenShot(string DirectoryName, string filename)
        {
            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            filename = GetPath(DirectoryName, filename);
            var screen = CustomBaseClass.MyDriver.TakeScreenshot();
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            return;
        }

        private static string GetPath(string DirectoryName, string filename)
        {
            string Location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            filename = Location + Path.DirectorySeparatorChar + DirectoryName + Path.DirectorySeparatorChar + filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
            return filename;
        }


        public static bool IsTextPresent(IWebDriver driver, string text)
        {
            try
            {
                return driver.FindElements(By.XPath($"//*[contains(text(),'{text}')]")).Count >= 1;
            }
            catch (NoSuchElementException err)
            {
                //Logger.Warn(err.StackTrace);
            }
            return false;
        }



    }
}
