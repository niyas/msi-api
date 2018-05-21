using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace msi_api.Models
{
    public class Name
    {
        public int SubjectId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mi { get; set; }
        public string Suffix { get; set; }

        public virtual List<Address> Address { get; set; }
    }
}