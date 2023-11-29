using Newtonsoft.Json;
using System.Diagnostics;

namespace API2.Helpers
{
    static class ObjectsHelper
    {
        public static void Dump(this object data)
        {
            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            Trace.WriteLine("");
            Trace.WriteLine(json);
        }
    }
}
