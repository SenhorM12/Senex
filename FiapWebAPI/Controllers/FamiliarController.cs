using Microsoft.AspNetCore.Mvc;
using FiapWebAPI.Models;
using FiapWebAPI.Repository;

namespace FiapWebAPI.Controllers
{
    public class FamiliarController : Controller
    {
        private readonly FamiliarRepository familiarRepository;
        public FamiliarController()
        {
            familiarRepository = new FamiliarRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaFamiliar = familiarRepository.List();
            return View(listaFamiliar);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Models.Familiar());
        }

        [HttpPost]
        public IActionResult Create(Models.Familiar familiar)
        {

            if (ModelState.IsValid)
            {
                familiarRepository.Create(familiar);
                return RedirectToAction("Index", "Familiar");
            }
            else
            {
                return View(familiar);
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var familiar = familiarRepository.Detail(Id);
            return View(familiar);
        }

        [HttpPost]
        public IActionResult Edit(Models.Familiar familiar)
        {
            if (ModelState.IsValid)
            {
                familiarRepository.Edit(familiar);
                return RedirectToAction("Index", "Familiar");
            }
            else
            {
                return View(familiar);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            familiarRepository.Delete(Id);
            return RedirectToAction("Index", "Familiar");
        }

    }
}
