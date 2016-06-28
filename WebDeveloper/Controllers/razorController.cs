using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: razor
        [Route]
        public ActionResult Index()
        {
            var client = new Client()
            {
                ID = 1,
                LastName = "Cueva",
                Name = "Aladino"
            };
            return View(client);
        }
        public ActionResult Product()
        {
            var productData = new ProductData();
            return View(productData.GetFakeProducts());
        }

        [Route("Entry/{date:DateTime}")]
        public ActionResult EntryDate(DateTime date)
        {
            ViewBag.Date = date.ToShortDateString();
       
            return View();
        }

        [Route("Entry/{id:int}")]
        public string EntryId(int id)
        {
            return id.ToString();
        }
    }
}