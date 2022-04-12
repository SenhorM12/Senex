using Microsoft.AspNetCore.Mvc;
using FiapWebAPI.Models;
using FiapWebAPI.Repository;

namespace FiapWebAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository userRepository;
        public UserController()
        {
            userRepository = new UserRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaUser = userRepository.List();
            return View(listaUser);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Models.User());
        }

        [HttpPost]
        public IActionResult Create(Models.User user)
        {

            if (ModelState.IsValid)
            {
                userRepository.Create(user);
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var user = userRepository.Detail(Id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(Models.User user)
        {
            if (ModelState.IsValid)
            {
                userRepository.Edit(user);
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            userRepository.Delete(Id);
            return RedirectToAction("Index", "User");
        }

    }
}
