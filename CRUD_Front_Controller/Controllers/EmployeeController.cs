using Microsoft.AspNetCore.Mvc;

namespace CRUD_Front_Controller.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
