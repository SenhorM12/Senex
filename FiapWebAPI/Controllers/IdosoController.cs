using Microsoft.AspNetCore.Mvc;
using Senex.Models;
using Senex.Repository;

namespace Senex.Controllers
{
    public class IdosoController : Controller
    {
        private readonly IdosoRepository idosoRepository;
        public IdosoController()
        {
            idosoRepository = new IdosoRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaIdoso = idosoRepository.List();
            return View(listaIdoso);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Models.Idoso());
        }

        [HttpPost]
        public IActionResult Create(Models.Idoso idoso)
        {

            if (ModelState.IsValid)
            {
                idosoRepository.Create(idoso);
                return RedirectToAction("Index", "Idoso");
            }
            else
            {
                return View(idoso);
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var idoso = idosoRepository.Detail(Id);
            return View(idoso);
        }

        [HttpPost]
        public IActionResult Edit(Models.Idoso idoso)
        {
            if (ModelState.IsValid)
            {
                idosoRepository.Edit(idoso);
                return RedirectToAction("Index", "Idoso");
            }
            else
            {
                return View(idoso);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            idosoRepository.Delete(Id);
            return RedirectToAction("Index", "Idoso");
        }

    }
}
