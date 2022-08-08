using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Proceso_168016__sgdetest.TestData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Proceso_168016__sgdetest.Hooks
{
    public class JsonClass
    {
        static string _Baseurl;
        static String JsonGlobal;

        public JsonClass(string Baseurl)
        {
            _Baseurl = Baseurl;
        }

        public static string ReadJson(string FileName)
        {
            String json = "";
            try
            {


                string path = Path.GetFullPath(_Baseurl + "\\" + FileName + ".json");

                using (var stream = new FileStream(path, FileMode.Open))
                using (var reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

                json = "No se encontro el " + FileName + ".json";
            }
            JsonGlobal = json;
            return json;
        }


        public static EntityClass Get_entity(string propiedad)
        {
            EntityClass entity = new EntityClass();
            try
            {
                JObject obj = JObject.Parse(JsonGlobal);
                entity.ValueToFind = (string)obj[propiedad]["ValueToFind"];
                entity.GetFieldBy = (string)obj[propiedad]["GetFieldBy"];   //GetFieldBy

            }
            catch (Exception ex)
            {

                Console.WriteLine("No se encontro la key a la cual se hace referencia", ex.Message);
                // "No se encontro la key a la cual se hace referencia";
            }


            return entity;
        }









    }
}
