using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client = new ClientData();
        // GET: Client
        public ActionResult Index()
        {
           

            return View(_client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());

        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
           if(ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}