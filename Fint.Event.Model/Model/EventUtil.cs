using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fint.Event.Model
{
    public class EventUtil
    {
        public static Event<T> ToEvent<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<Event<T>>(json);
            }
            catch
            {
                return null;
            }
        }

        public static string ToJson<T>(Event<T> evt)
        {
            try
            {
                return JsonConvert.SerializeObject(evt);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
