using BuisnessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCProjeKampi.Controllers
{
    public class CategoryController : Controller
    {        
        CategoryManager cm = new CategoryManager();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View (categoryvalues);
        }

        [HttpGet] public ActionResult GetCategory(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            cm.AddCategory(p);
            return RedirectToAction("GetCategoryList");
        }
        
    }
}