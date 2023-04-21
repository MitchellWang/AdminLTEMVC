using Microsoft.AspNetCore.Mvc;

namespace AdminLTEMVC.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleTables()
        {
            return View();
        }
        public IActionResult DataTables()
        {
            return View();
        }
    }
}
