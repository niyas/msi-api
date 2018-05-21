using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace msi_api.Models
{
    public class msiContext : DbContext
    {
        public msiContext() : base()
        {

        }
        public DbSet<Name> Name { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}