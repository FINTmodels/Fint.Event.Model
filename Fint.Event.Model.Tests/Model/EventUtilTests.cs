using System;
using Xunit;

namespace Fint.Event.Model.Tests.Model
{
    public class EventUtilTests
    {
        [Fact]
        public void ConvertEventToJson()
        {
            var evt = new Event<string>("rogfk.no", "fk", "GET_ALL", "myClient");

            string json = EventUtil.ToJson(evt);

            Assert.True(json.StartsWith("{"));
            Assert.True(json.EndsWith("}"));
            Assert.True(json.Contains("rogfk.no"));
        }

        [Fact]
        public void ConvertJsonToEvent()
        {
            String json = "{\"corrId\": \"9b71b7ab-c06d-400a-bca3-f06659006000\",  \"action\":" +
                " \"GET_ALL_EMPLOYEES\",  \"status\": \"DOWNSTREAM_QUEUE\", " +
                " \"time\": 1479909169834,  \"orgId\": \"rogfk.no\",  " +
                "\"source\": \"employee\",  \"client\": \"vfs\",  \"message\": null, " +
                "\"responseStatus\": \"ACCEPTED\"" +
                "}";

            var evt = EventUtil.ToEvent<string>(json);

            Assert.True(evt != null);
            Assert.True(evt.Action == "GET_ALL_EMPLOYEES");
            Assert.True(evt.ResponseStatus == ResponseStatus.ACCEPTED);

        }
    }
}
