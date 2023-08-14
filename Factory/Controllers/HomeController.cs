
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Collections.Generic;

namespace Factory.Controllers
{
    public class HomeController : Controller
        {
            private readonly FactoryContext _db;
            public HomeController(FactoryContext db)
            {
                _db = db;
            }

        [HttpGet("/")]
        public ActionResult Index()
        {
            Machine[] machines = _db.Machines.ToArray();
            Engineer[] engineers = _db.Engineers.ToArray();
            Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            model.Add("Machines", machines);
            model.Add("Engineers", engineers);

            return View(model);
        }
    }
}
