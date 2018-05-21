using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using msi_api.Models;

namespace msi_api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            using(msiContext entities = new msiContext())
            {
                var name = new Name() { FirstName = "Mohammed Niyas", LastName = "Nizamudheen" };
                var address = new Address() { City = "Chennai", State = "Tamil Nadu" };
                entities.Name.Add(name);
                name.Address.Add(address);
                entities.SaveChanges();
            }
            
            return View();
        }
    }
}
