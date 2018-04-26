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

        [Fact]
        public void ConvertFullJsonToEvent()
        {
            String json = "{\n" +
                "  \"corrId\": \"a91cdb9b-0292-4baf-9a27-578642634129\",\n" +
                "  \"action\": \"GET_ALL\",\n" +
                "  \"status\": \"NEW\",\n" +
                "  \"time\": 1524131147134,\n" +
                "  \"orgId\": \"rogfk.no\",\n" +
                "  \"source\": \"fk\",\n" +
                "  \"client\": \"myClient\",\n" +
                "  \"data\": [],\n" +
                "  \"message\": \"There is a disturbance in the Force\",\n" +
                "  \"query\": \"what\",\n" +
                "  \"problems\": [\n" +
                "    {\n" +
                "      \"field\": \"monkey\",\n" +
                "      \"message\": \"Only chimpanzees allowed\",\n" +
                "      \"code\": \"9999\"\n" +
                "    },\n" +
                "    {\n" +
                "      \"field\": \"jedi\",\n" +
                "      \"message\": \"Luke not found\",\n" +
                "      \"code\": \"44\"\n" +
                "    }\n" +
                "  ],\n" +
                "  \"statusCode\": \"JEDI-XX\",\n" +
                "  \"responseStatus\": \"ERROR\"\n" +
                "}";

            var evt = EventUtil.ToEvent<string>(json);

            Assert.NotNull(evt);
            //Assert.Equal(ResponseStatus.ERROR, evt.ResponseStatus);
            Assert.Equal("JEDI-XX", evt.StatusCode);
            Assert.Equal(2, evt.Problems.Count);
            Assert.Equal("9999", evt.Problems[0].Code);
        }
    }
}
