using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using msi_api.Models;
using System.Web.Http.Cors;

namespace msi_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MsiController : ApiController
    {
        public HttpResponseMessage Post(HttpRequestMessage request, [FromBody] MsiPayload payload)
        {
           using(msiContext entities = new msiContext())
            {
                var name = payload.getName();
                entities.Name.Add(name);
                name.Address.Add(payload.getAddress());
                entities.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "{Message: Msi Data Saved successfully}");
            }
        }
    }
}
