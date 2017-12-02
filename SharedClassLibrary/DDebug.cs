using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace SharedClassLibrary
{
   public class DDebug
    {
      static public void LogDirOutput(string message, object o)
      {
         Debug.WriteLine("----------- " + message + " ----------");
         Debug.WriteLine(JsonConvert.SerializeObject(o, new JsonSerializerSettings()
         {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
         }));
      }

      static public void LogDirConsole(string message, object o)
      {
         Console.WriteLine("----------- " + message + " ----------");
         Console.WriteLine(JsonConvert.SerializeObject(o, new JsonSerializerSettings()
         {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
         }));
      }

      static public string ToStringify(object o)
      {
        return JsonConvert.SerializeObject(o, new JsonSerializerSettings()
         {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
         });
      }
   }
}
