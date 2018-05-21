using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace msi_api.Models
{
    public class Name
    {
        [Key]
        public int SubjectId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mi { get; set; }
        public string Suffix { get; set; }

        public ICollection<Address> Address { get; set; }

        public Name()
        {
            this.Address = new HashSet<Address>();
        }
    }

}