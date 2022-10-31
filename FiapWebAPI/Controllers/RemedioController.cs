using Microsoft.AspNetCore.Mvc;
using Senex.Repository;
using Senex.Models;

namespace Senex.Controllers
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
            return View(new Remedio());
        }

        [HttpPost]
        public IActionResult Create(Remedio remedio)
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
        public IActionResult Edit(Remedio remedio)
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
