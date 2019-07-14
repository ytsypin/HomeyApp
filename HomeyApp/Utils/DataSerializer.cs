using System;
using Newtonsoft.Json;

namespace HomeyApp.Utils
{
    public static class DataSerializer
    {
        public static string SerializeToJson(object obj)
        {
            try
            {
                var json = JsonConvert.SerializeObject(obj);
                return json;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static T DeserializeFromJson<T>(string jsonObj)
        {
            try
            {
                var result = JsonConvert.DeserializeObject<T>(jsonObj);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        }
}