using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceso_168016__sgdetest.Hooks
{
    public class FindElemenstClass
    {
        public static IWebDriver _driver;
        public FindElemenstClass(IWebDriver driver)
        {
            _driver = driver;
        }

        public static IWebDriver GetDriver(string GetFieldBy, string ValueToFind)
        {
            IWebDriver element = null;
            try
            {


                if (GetFieldBy == "iframe")
                    element = _driver.SwitchTo().Frame(_driver.FindElement(By.XPath(ValueToFind)));


            }
            catch (Exception ex)
            {

                throw;
            }


            return element;
        }

        public static IWebElement GetElement(string GetFieldBy, string ValueToFind)
        {
            IWebElement element = null;
            try
            {
                if (GetFieldBy == "id")
                    element = _driver.FindElement(By.Id(ValueToFind));

                if (GetFieldBy == "name")
                    element = _driver.FindElement(By.Name(ValueToFind));

                if (GetFieldBy == "xpath")
                    element = _driver.FindElement(By.XPath(ValueToFind));

                if (GetFieldBy == "link")
                    element = _driver.FindElement(By.LinkText(ValueToFind));

                if (GetFieldBy == "css")
                    element = _driver.FindElement(By.CssSelector(ValueToFind));

                if (GetFieldBy == "class")
                    element = _driver.FindElement(By.ClassName(ValueToFind));

                if (GetFieldBy == "tag")
                    element = _driver.FindElement(By.TagName(ValueToFind));

            }
            catch (Exception)
            {

                throw;
            }


            return element;

        }
    }
}
