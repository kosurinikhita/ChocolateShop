using System.Collections.Generic;
using System.Web.Mvc;
using ChocolateShop.entity;
using ChocolateShop.repository;

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
            return View();
        }
       

        [HttpPost]
        public ActionResult Create(Chocolate chocolate)
        {
            chocolateRepository.AddChocolate(chocolate);
            TempData["Message"] = "Chocolate added successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string Name)
        {
            chocolateRepository.DeleteChocolate(Name);
            TempData["Message"] = "Chocolate deleted successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string name)
        {
            Chocolate chocolate = chocolateRepository.GetChocolate(name);
            return View(chocolate);
        }

        [HttpPost]
       public ActionResult Update(Chocolate chocolate)
        {
            chocolateRepository.UpdateChocolate(chocolate);
            TempData["Message"] = "Updated successfully";
            return RedirectToAction("Index");
        }
       
    }
}