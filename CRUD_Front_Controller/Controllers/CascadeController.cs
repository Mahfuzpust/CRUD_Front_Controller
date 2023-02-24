using CRUD_Front_Controller.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Front_Controller.Controllers
{
    public class CascadeController : Controller
    {
        private readonly ApplicationDbContext context;
        public CascadeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public JsonResult Country()
        {
            var cnt = context.Countries.ToList();
            return new JsonResult(cnt);
        }

        public JsonResult State(int id)
        {
            var st = context.States.Where(u => u.Country.Id == id).ToList();
            return new JsonResult(st);
        }
        public JsonResult City(int id)
        {
            var ct = context.Cities.Where(u => u.State.Id == id).ToList();
            return new JsonResult(0);
        }


        public IActionResult CaseCadeDropdown()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
