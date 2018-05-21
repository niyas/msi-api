using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using msi_api.Models;

namespace msi_api.Controllers
{
    public class MsiController : ApiController
    {
        public void Post([FromBody] Name name)
        {
            using(msiContext entities = new msiContext())
            {
                entities.Name.Add(name);
                entities.SaveChanges();
            }
        }
    }
}
