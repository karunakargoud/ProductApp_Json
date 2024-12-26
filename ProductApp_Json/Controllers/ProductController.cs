using ProductApp_Json.DAL;
using ProductApp_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductApp_Json.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        public ProductController()
        {
            _context = new ProductContext();
        }
        public ActionResult GetAllProduct()
        {
            List<Product> plist = _context.products.ToList();
            return View("Display", plist);
        }
        public ActionResult GetProductsData()
        {
            List<Product>plist=_context.products.ToList();
            return Json(plist, JsonRequestBehavior.AllowGet);
        }
    }
}