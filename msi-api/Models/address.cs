using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace msi_api.Models
{
    public class Address
    { 
        [Key]
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Direction { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public ICollection<Name> Name { get; set; }

        public Address()
        {
            this.Name = new HashSet<Name>();
        }
    }
}