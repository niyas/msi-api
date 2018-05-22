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
            address = "2345 first cross",
            city = "Chennai",
            state = "Tamil Nadu",
            zip = "600077"
        };
        [TestMethod]
        public void getName()
        {
            var name = payload.getName();
            Assert.AreEqual(name.FirstName, "Mohammed");
            Assert.AreEqual(name.LastName, "Niyas");
            Assert.AreEqual(name.Mi, "Mr");
            Assert.AreEqual(name.Suffix, "B.E");
        }

        [TestMethod]
        public void getAddress()
        {
            var address = payload.getAddress();
            Assert.AreEqual(address.Street, "2345");
            Assert.AreEqual(address.Direction, "first");
            Assert.AreEqual(address.StreetName, "cross");
            Assert.AreEqual(address.StreetType, null);
            Assert.AreEqual(address.City, "Chennai");
            Assert.AreEqual(address.State, "Tamil Nadu");
            Assert.AreEqual(address.Zip, "600077");
        }
    }
}
