using Proceso_168016__sgdetest.Hooks;
using Proceso_168016__sgdetest.PageObjects;
using System;
using TechTalk.SpecFlow;
using Proceso_168016__sgdetest.TestData;
using OpenQA.Selenium;


namespace Proceso_168016__sgdetest.StepDefinations
{
    [Binding]
    public class ProcesoSteps
    {
        [When(@"Cambie al frame (.*)")]
        public void WhenCambieAlFrameX(string elemvaluefind)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetDriver(ele.GetFieldBy, ele.ValueToFind);
        }

        [Then(@"Escribo en el campo (.*) ingreso (.*)")]
        public void ThenEscriboEnElCampoXIngresoY(string elemvaluefind, string text)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);


            CustomBaseClass.EnterText3(eleText, text);
        }

        [When(@"subo el archivo (.*) en en el campo (.*)")]
        public void WhenSuboElArchivoXEnEnElCampoY(string elemvaluefind, string text)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);


            CustomBaseClass.CargarArchivo(eleText, text);
        }

        [When(@"salir del iframe")]
        public void WhenSalirDelIframe()
        {
            FindElemenstClass._driver.SwitchTo().ParentFrame();
        }

        [When(@"pegar referencia del caso (.*)")]
        public void WhenPegarReferenciaDelCasoV(String elemvaluefind)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);


            CustomBaseClass.ctrlv(eleText);
        }

        static String JsonGlobal;
        [Then(@"El usuario es redirecionado (.*)")]
        public void ThenUserShouldBeRedirectedToHomePage(string elemvalue)
        {
            try
            {
                EntityClass elem = JsonClass.Get_entity(elemvalue);
                var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
                AssertClass.AssertElementIsPresent(elementoo);
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not verify Home: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"en el campo (.*) ingreso (.*)")]
        public void ThenEnElCampoXIngresoY(string elemvaluefind, string text)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);

            CustomBaseClass.EnterText2(eleText, text);
        }

        [When(@"limpia el campo (.*)")]
        public void WhenLimpiaElCampoX(string elem)
        {
            EntityClass ele = JsonClass.Get_entity(elem);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);

            CustomBaseClass.ClearText(eleText);
        }


        [When(@"realizo Scroll (.*)")]
        public void WhenRealizoScroll(string elem)
        {
            EntityClass ele = JsonClass.Get_entity(elem);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);

            CustomBaseClass.ScrollintoView(eleText);
        }

        [When(@"Cargo el  DOM de la app: (.*)")]
        public void GivenCargoElDOMDeLaAppInisioSesion(string FileName)
        {
            JsonClass json = new JsonClass(TestConfig.BaseDir);
            JsonGlobal = JsonClass.ReadJson(FileName);

        }

        [When(@"Cargo el  dom de la app: (.*)")]
        public void WhenCargoElDomDeLaAppConfiguracionPer(string FileName)
        {
            JsonClass json = new JsonClass(TestConfig.BaseDir);
            JsonGlobal = JsonClass.ReadJson(FileName);
        }


        [Then(@"Clic en el (.*)")]
        [Obsolete]
        public void ThenClicEnElBoton(string elemvalue)
        {

            EntityClass elem = JsonClass.Get_entity(elemvalue);
            DriverClass.PageLoaded(elem.ValueToFind, elem.GetFieldBy);
            var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
            elementoo.Click();

        }

        [Then(@"DobleClic (.*)")]
        [Obsolete]
        public void ThenDobleClicX(string elemvalue)
        {
            EntityClass elem = JsonClass.Get_entity(elemvalue);
            DriverClass.PageLoaded(elem.ValueToFind, elem.GetFieldBy);
            var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
            CustomBaseClass.DoubleClick(elementoo);
        }


        [Then(@"Click en el (.*)")]
        [Obsolete]
        public void ThenClickEnElBtnSi(string elemvalue)
        {
            //ScenarioContext.Current.Pending();
            EntityClass elem = JsonClass.Get_entity(elemvalue);
            DriverClass.PageLoaded(elem.ValueToFind, elem.GetFieldBy);
            var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
            elementoo.Click();

        }


        [When(@"Se valida los campos obligatorios (.*)")]
        [Obsolete]
        public void WhenSeValidaLosCamposObligatoriosX(string elemvalue)
        {
            EntityClass elem = JsonClass.Get_entity(elemvalue);
            DriverClass.PageLoaded(elem.ValueToFind, elem.GetFieldBy);
            var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
            AssertClass.AssertElementIsPresent(elementoo);
        }

        [Then(@"se valida mensaje de confimacion (.*)")]
        [Obsolete]
        public void ThenSeValidaMensajeDeConfimacion(string elemvalue)
        {
            EntityClass elem = JsonClass.Get_entity(elemvalue);
            DriverClass.PageLoaded(elem.ValueToFind, elem.GetFieldBy);
            var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
            AssertClass.AssertElementIsPresent(elementoo);
        }

        [Then(@"Espera de (.*)")]
        public void ThenEsperaDe(int p0)
        {
            CustomBaseClass.Thinktime(p0);
        }


        [Then(@"se verifica el cerrado (.*) de la sesion")]
        public void ThenSeVerificaElCerradoXDeLaSesion(string elemvalue)
        {
            try
            {
                EntityClass elem = JsonClass.Get_entity(elemvalue);
                var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
                AssertClass.AssertElementIsPresent(elementoo);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: No se encuentra el elemento: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"se verifica el desbloqueo de la sesion (.*)")]
        public void ThenSeVerificaElDesbloqueoDeLaSesionBtnPerfil(string elemvalue)
        {
            try
            {
                EntityClass elem = JsonClass.Get_entity(elemvalue);
                var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
                AssertClass.AssertElementIsPresent(elementoo);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: No desbloqueo: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"Refresh")]
        public void ThenRefresh()
        {
            CustomBaseClass.Refresh();
        }

        [Then(@"se verifica que no se bloquea la sesion (.*)")]
        public void ThenSeVerificaQueNoSeBloqueaLaSesionBtnPerfil(string elemvalue)
        {
            try
            {
                EntityClass elem = JsonClass.Get_entity(elemvalue);
                var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
                AssertClass.AssertElementIsPresent(elementoo);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: Se desbloqueo: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }


        [Then(@"se verifica que no se desbloqueo la sesion (.*)")]
        public void ThenSeVerificaQueNoSeDesbloqueoLaSesionBtnPerfil(string elemvalue)
        {
            try
            {
                EntityClass elem = JsonClass.Get_entity(elemvalue);
                var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
                AssertClass.AssertElementIsPresent(elementoo);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: Se desbloqueo: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [When(@"validacion inconsistencias (.*)")]
        public void WhenValidacionInconsistenciasX(string elemvalue)
        {
            try
            {
                EntityClass elem = JsonClass.Get_entity(elemvalue);
                var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
                AssertClass.IsElementPresent(elementoo);


            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed:Inconsistencia en el guardado : {0}", E.Message);
                throw;
            }
        }


        [Then(@"cuando se desbloquea debe quedar en la pagina de inicio (.*)")]
        public void ThenCuandoSeDesbloqueaDebeQuedarEnLaPaginaDeInicioX(string elemvalue)
        {
            try
            {
                EntityClass elem = JsonClass.Get_entity(elemvalue);
                var elementoo = FindElemenstClass.GetElement(elem.GetFieldBy, elem.ValueToFind);
                AssertClass.AssertElementIsPresent(elementoo);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: No ingreso a la home : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [When(@"Minimiza la ventana")]
        public void WhenMinimizaLaVentana()
        {
            CustomBaseClass.Minimizethewindow();
        }

        [Then(@"maximiza la ventana")]
        public void ThenMaximizaLaVentana()
        {
            CustomBaseClass.Maximizewindow();
        }

        [Then(@"Toma pantallazo")]
        public void ThenTomaPantallazo()
        {

            //GeneralHook.AfterScenario();

        }

    }
}
