using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using msi_api.Models;

namespace msi_api.Controllers
{
    public class MsiPayload
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mi { get; set; }
        public string suffix { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }


        public Name getName()
        {
            Name name = new Name()
            {
                FirstName = this.firstName,
                LastName = this.lastName,
                Mi = this.mi,
                Suffix = this.suffix
            };

            return name;
        }

        public Address getAddress()
        {
            string[] splitAddress = this.address.Split(' ');
            Address address = new Address()
            {
                Street = splitAddress.Length >= 1 ? splitAddress[0] : null,
                Direction = splitAddress.Length >= 2 ? splitAddress[1] : null,
                StreetName = splitAddress.Length >= 3 ? splitAddress[2] : null,
                StreetType = splitAddress.Length >= 4 ? splitAddress[3] : null,
                City = this.city,
                State = this.state,
                Zip = this.zip
            };
            return address;
        }
    }
}
