using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Shape_put_10_please_
{
    class JSON
    {
        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
