using System.Collections.Generic;
using System.Web.Mvc;
using ChocolateShop.BL;
using ChocolateShop.DAL;
using ChocolateShop.entity;

namespace ChocolateShop.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Index
        ChocolateRepository chocolateRepository;
        public DefaultController()
        {
            chocolateRepository = new ChocolateRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<Chocolate> chocolate = chocolateRepository.GetChocolateDetails();
            return View(chocolate);
        }
        
        public ActionResult Create()
        {
            List<Categories> categories = CategoriesBL.DownDrop();
            ViewBag.categories = new SelectList(categories, "CategoryId", "Name");
            return View();
            
        }
        public ActionResult Login()
        {
            ViewBag.message = "Successfully logged in";
            return View();
        }


        [HttpPost]
       // [ValidateAntiForgeryToken()]
        public ActionResult Create(Chocolate chocolate)
        {
            chocolateRepository.AddChocolate(chocolate);
            TempData["Message"] = "Chocolate added successfully!";
            try
            {
                if (ModelState.IsValid)
                {
                    Categories categories = new Categories();
                    categories.CategorieId = chocolate.CategorieId;
                    List<Categories> categories = ChocolateBL.DownDrop();
                    ViewBag.categories = new SelectList(categories, "CategorieId", "Name");
                    CategorieBL.CreateCategories();
                    return RedirectToAction("GetChocolateDetails");
                }
            }
            catch
            {
                View("Error");
            }
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(string Name)
        {
            chocolateRepository.DeleteChocolate(Name);
            TempData["Message"] = "Chocolate deleted successfully";
            return RedirectToAction("Index");
        }
        
        public ActionResult Edit(string Id)
        {
            Chocolate chocolate = chocolateRepository.GetChocolate(Id);
            return View(chocolate);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken()]
        public ActionResult Update(Chocolate chocolate)
        {
            chocolateRepository.UpdateChocolate(chocolate);
            TempData["Message"] = "Updated successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Create_Post()
        {
            Chocolate chocolate = new Chocolate();
            TryUpdateModel(chocolate);
            if (ModelState.IsValid)
            {
                chocolateRepository.AddChocolate(chocolate);
                TempData["Message"] = "Chocolate added successfully!!!";
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}