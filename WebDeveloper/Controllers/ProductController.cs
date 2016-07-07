using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        private ProductData _product;

        public ProductController(ProductData client)
        {
            _product = client;
        }

        // GET: Product
        public ActionResult Index()
        {
            //ViewBag.Title = Resources.Resource.;
            return View(_product.GetFakeProducts());
        }

        //public ActionResult Create()
        //{
        //    return View(new Product());
        //}

        //[HttpPost]
        //public ActionResult Create(Product Product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _Product.Add(Product);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //public ActionResult Edit(int ID)
        //{
        //    Product Product = _Product.GetProductById(ID);
        //    if (Product == null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(Product);
        //}

        //[HttpPost]
        //public ActionResult Edit(Product Product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _Product.Update(Product);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //public ActionResult Delete(int ID)
        //{
        //    Product Product = _Product.GetProductById(ID);
        //    if (Product == null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(Product);
        //}

        //[HttpPost]
        //public ActionResult Delete(Product Product)
        //{
        //    if (_Product.Delete(Product) > 0)
        //        return RedirectToAction("Index");
        //    return View(Product);
        //}
    }
}