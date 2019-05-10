using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;// Class for JSON serialization
using System.Text;

namespace SerializationDemo
{
    class JsonHelper<T>
    {
        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            //create object of Stream to write into
            MemoryStream ms = new MemoryStream();
            string jsonString;
            try
            {
                //Serialize the object
                ser.WriteObject(ms, t);

                //Get the Encoded Json String
                jsonString = Encoding.UTF8.GetString(ms.ToArray());
            }
            catch (Exception e) {
                throw;
             }
            finally { 
            //close the MS
            ms.Close();
            }
            return jsonString;
        }

        public static T JsonDeserialize<T>(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

            //Deserialize the Bytes received from MS
            T obj = (T)ser.ReadObject(ms);
            return obj;
        }
    }
}
