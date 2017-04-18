using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FintEventModel.Model
{
    public class EventUtil
    {
        public static Event ToEvent(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<Event>(json);
            }
            catch
            {
                return null;
            }
        }

        public static IEnumerable<string> ConvertEventData(Event evt)
        {
            throw new NotImplementedException();
        }

        public static string ToJson(Event evt)
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
