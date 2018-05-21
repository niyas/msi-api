using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using msi_api;
using msi_api.Controllers;

namespace msi_api.Tests.Controllers
{
    [TestClass]
    public class MsiPayloadTest
    {
        MsiPayload payload = new MsiPayload()
        {
            firstName = "Mohammed",
            lastName = "Niyas",
            mi = "Mr",
            suffix = "B.E",
            address = "2345 first cross street",
            city = "Chennai",
            state = "Tamil Nadu",
            zip = "600077"
        };
        [TestMethod]
        public void getName()
        {
            var name = payload.getName();
            Assert.Equals(name.FirstName, "Mohammed");
            Assert.Equals(name.LastName, "Niyas");
            Assert.Equals(name.Mi, "Mr");           
        }
    }
}
