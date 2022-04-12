using Microsoft.AspNetCore.Mvc;
using FiapWebAPI.Models;
using FiapWebAPI.Repository;

namespace FiapWebAPI.Controllers
{
    public class MedController : Controller
    {
        private readonly MedicoRepository medicoRepository;
        public MedController()
        {
            medicoRepository = new MedicoRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaMedico = medicoRepository.List();
            return View(listaMedico);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Models.Medico());
        }

        [HttpPost]
        public IActionResult Create(Models.Medico medico)
        {

            if (ModelState.IsValid)
            {
                medicoRepository.Create(medico);
                return RedirectToAction("Index", "Medico");
            }
            else
            {
                return View(medico);
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var medico = medicoRepository.Detail(Id);
            return View(medico);
        }

        [HttpPost]
        public IActionResult Edit(Models.Medico medico)
        {
            if (ModelState.IsValid)
            {
                medicoRepository.Edit(medico);
                return RedirectToAction("Index", "Medico");
            }
            else
            {
                return View(medico);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            medicoRepository.Delete(Id);
            return RedirectToAction("Index", "Medico");
        }

    }
}
