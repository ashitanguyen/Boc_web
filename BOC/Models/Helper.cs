using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOC.Models
{
    public static class Helper
    {
        public static string AsJsonList<T>(List<T> tt)
        {
            return new JavaScriptSerializer().Serialize(tt);
        }
        public static string AsJson<T>(T t)
        {
            return new JavaScriptSerializer().Serialize(t);
        }
        public static List<T> AsObjectList<T>(string tt)
        {
            return new JavaScriptSerializer().Deserialize<List<T>>(tt);
        }
        public static T AsObject<T>(string t)
        {
            return new JavaScriptSerializer().Deserialize<T>(t);
        }
    }
}
