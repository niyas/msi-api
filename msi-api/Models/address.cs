using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace msi_api.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int Street { get; set; }
        public string Direction { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}