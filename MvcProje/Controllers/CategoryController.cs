using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categorValues = cm.GetAll();
            return View(categorValues);
        }
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categorValues = cm.GetAll();
            return PartialView(categorValues);
        }

    }
}