using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace msi_api.Models
{
    public class msiContext: DbContext
    {
        public DbSet<Name> Names { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}