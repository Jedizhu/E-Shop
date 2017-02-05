using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eshop.DAL;
using eshop.Models;

namespace eshop.Controllers
{
    public class StoreFrontController : Controller
    {

        private eshopContext db = new eshopContext();
        // GET: StoreFront
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
    }
}