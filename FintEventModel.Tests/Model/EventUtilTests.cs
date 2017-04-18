using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FintEventModel.Model;

namespace FintEventModel.Tests
{
    [TestClass]
    public class EventUtilTests
    {
        [TestMethod]
        public void ConvertEventToJson()
        {
            var evt = new Event("rogfk.no", "fk", "GET_ALL", "myClient");

            string json = EventUtil.ToJson(evt);

            Assert.IsTrue(json.StartsWith("{"));
            Assert.IsTrue(json.EndsWith("}"));
            Assert.IsTrue(json.Contains("rogfk.no"));
        }

        [TestMethod]
        public void ConvertJsonToEvent()
        {
            String json = "{\"corrId\": \"9b71b7ab-c06d-400a-bca3-f06659006000\",  \"action\":" +
                " \"GET_ALL_EMPLOYEES\",  \"status\": \"DOWNSTREAM_QUEUE\", " +
                " \"time\": 1479909169834,  \"orgId\": \"rogfk.no\",  " +
                "\"source\": \"employee\",  \"client\": \"vfs\",  \"message\": null" +
                "}";

            var evt = EventUtil.ToEvent(json);

            Assert.IsTrue(evt != null);
            Assert.IsTrue(evt.Action == "GET_ALL_EMPLOYEES");

        }
    }
}
