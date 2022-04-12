using Microsoft.AspNetCore.Mvc;
using FiapWebAPI.Models;
using FiapWebAPI.Repository;

namespace FiapWebAPI.Controllers
{
    public class PosologiaController : Controller
    {
        private readonly PosologiaRepository posologiaRepository;
        public PosologiaController()
        {
            posologiaRepository = new PosologiaRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaPosologia = posologiaRepository.List();
            return View(listaPosologia);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Models.Posologia());
        }

        [HttpPost]
        public IActionResult Create(Models.Posologia posologia)
        {

            if (ModelState.IsValid)
            {
                posologiaRepository.Create(posologia);
                return RedirectToAction("Index", "Posologia");
            }
            else
            {
                return View(posologia);
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var posologia = posologiaRepository.Detail(Id);
            return View(posologia);
        }

        [HttpPost]
        public IActionResult Edit(Models.Posologia posologia)
        {
            if (ModelState.IsValid)
            {
                posologiaRepository.Edit(posologia);
                return RedirectToAction("Index", "Posologia");
            }
            else
            {
                return View(posologia);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            posologiaRepository.Delete(Id);
            return RedirectToAction("Index", "Posologia");
        }

    }
}
