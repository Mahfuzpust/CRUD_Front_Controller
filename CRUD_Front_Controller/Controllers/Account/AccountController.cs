using CRUD_Front_Controller.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Front_Controller.Controllers.Account
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginSignUpViewModel model)
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TempData["errorMessage"] = "Empty form can not submitted";
                return View(model);
            }
        }

    }
}
