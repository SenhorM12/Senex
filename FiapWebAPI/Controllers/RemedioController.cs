using Microsoft.AspNetCore.Mvc;
using FiapWebAPI.Models;
using FiapWebAPI.Repository;

namespace FiapWebAPI.Controllers
{
    public class RemedioController : Controller
    {
        private readonly RemedioRepository remedioRepository;
        public RemedioController()
        {
            remedioRepository = new RemedioRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaRemedio = remedioRepository.List();
            return View(listaRemedio);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Models.Remedio());
        }

        [HttpPost]
        public IActionResult Create(Models.Remedio remedio)
        {

            if (ModelState.IsValid)
            {
                remedioRepository.Create(remedio);
                return RedirectToAction("Index", "Remedio");
            }
            else
            {
                return View(remedio);
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var remedio = remedioRepository.Detail(Id);
            return View(remedio);
        }

        [HttpPost]
        public IActionResult Edit(Models.Remedio remedio)
        {
            if (ModelState.IsValid)
            {
                remedioRepository.Edit(remedio);
                return RedirectToAction("Index", "Remedio");
            }
            else
            {
                return View(remedio);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            remedioRepository.Delete(Id);
            return RedirectToAction("Index", "Remedio");
        }

    }
}
