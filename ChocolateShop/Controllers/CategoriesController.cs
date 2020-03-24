using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChocolateShop.BL;
using ChocolateShop.DAL;
using ChocolateShop.entity;

namespace ChocolateShop.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        CategoriesRepository categoriesRepository;
        public CategoriesController()
        {
            categoriesRepository = new CategoriesRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<Categories> categories = categoriesRepository.GetCategoriesDetails();
            return View(categories);
        }
        
        [HttpPost]
        //[ValidateAntiForgeryToken()]
        public ActionResult CreateCategories(Categories categories)
        {
            categoriesRepository.AddCategories(categories);
            TempData["Message"] = "Categories added successfully!";
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteCategories(int Id)
        {
            categoriesRepository.DeleteCategories(Id);
            TempData["Message"] = "Categories deleted successfully";
            return RedirectToAction("Index");
        }
        
        public ActionResult EditCategories(string name)
        {
            Categories categories = categoriesRepository.GetCategories(name);
            return View(categories);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken()]
        public ActionResult UpdateCategories(Categories categories)
        {
            categoriesRepository.UpdateCategories(categories);
            TempData["Message"] = "Updated successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Create_Post()
        {
            Categories categories = new Categories();
            TryUpdateModel(categories);
            if (ModelState.IsValid)
            {
                categoriesRepository.AddCategories(categories);
                TempData["Message"] = "Chocolate added successfully!!!";
                return RedirectToAction("Index");
            }
            return View();
        }
         

    }
}