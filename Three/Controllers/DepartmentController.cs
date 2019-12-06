using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Three.Model;
using Three.Servers;

namespace Three.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServer _departentServer;
        public DepartmentController(IDepartmentServer departentServer)
        {
            _departentServer = departentServer;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "departent index";
            var departents = await _departentServer.GetALL();
            return View(departents);
        }
        public IActionResult Add()
        {
            ViewBag.Title = " add departent ";
            return View(new Department());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Department departent)
        {
            if (ModelState.IsValid)
            {
                await _departentServer.Add(departent);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
