using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace Proceso_168016__sgdetest.Hooks
{
    public static class AssertClass
    {
        public static void AssertElementIsPresent(this IWebElement element)
        {
            try
            {
                Assert.AreEqual(true, IsElementPresent(element));

            }

            catch (Exception ex)
            {
                Console.WriteLine("Test Failed, No element {0} is found ", ex.Message);
                throw ex;
            }
        }

        // Se asegura de que el caso de prueba no fallará a menos que sea absolutamente necesario.Devuelve verdadero o falso a AssertElement is Presesent Method
        public static bool IsElementPresent(IWebElement element)
        {
            bool Present = false;
            try
            {
                CustomBaseClass.MyDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                if (element.Displayed)
                {
                    Present = true;
                    Console.WriteLine("Element Is Seen");
                }

                else
                {
                    CustomBaseClass.MyDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                    if (element.Displayed)
                    {
                        Present = true;
                    }
                }
                return Present;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("No Such Element : {0}", ex.Message);
                Assert.Fail("No Such Element");
                return false;
            }
        }


        // Comprueba el texto y confirma que coincide
        public static void ContainsText(IWebElement element, string neededText)
        {
            string actualText = element.Text;
            try
            {
                if (actualText.Contains(neededText))
                {
                    Console.WriteLine("Text Matched");
                }
                else
                    Assert.Fail("Text mismatch");
            }
            catch (Exception e)
            {
                Console.WriteLine("Text Mismatched : {0}", e.Message);
                throw e;
            }
        }

        public static bool ElementPresent(IWebElement element)
        {
            bool Present = false;
            try
            {
                CustomBaseClass.MyDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                if (element.Displayed)
                {
                    Present = true;
                    Console.WriteLine("Elemento visible");
                    Assert.Fail("No se debe abrir la pestaña #6 ya que incumple con lo configurado");

                }
                else
                {
                    CustomBaseClass.MyDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                    if (element.Displayed)
                    {
                        Present = false;
                        Console.WriteLine("Elemento no esta visible");

                    }
                }
                return Present;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("No Such Element : {0}", ex.Message);
                throw ex;

            }
        }

    }
}
