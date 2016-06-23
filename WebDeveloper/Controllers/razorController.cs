using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: razor
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
    }
}