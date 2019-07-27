using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFormValidation.Controllers
{

    /// <summary>
    /// 3 steps to add validation
    /// 1-add html validation helper(addded by default)
    /// 2-add [required] attribute
    /// 3-add modelstate.isvalid check
    /// </summary>

    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            WebAppEntities db = new WebAppEntities();
            var categories = db.tbl_Category.ToList();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    WebAppEntities db = new WebAppEntities();
                    db.tbl_Category.Add(category);
                    db.SaveChanges();
                    TempData["msg"] = "Data added sucessfully!";
                    return RedirectToAction("Create");

                }
                else
                {
                    return View();
                }
            }
            catch(Exception e)
            {
                TempData["msg"] = "Data not added! " + e.Message;
                return View();
            }

            
        }
    }
}