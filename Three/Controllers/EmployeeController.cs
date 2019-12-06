using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Three.Model;
using Three.Servers;
namespace Three.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly IEmployeeServer _employeeServer;
        private readonly IDepartmentServer _departentServer;
        public EmployeeController(IEmployeeServer employee, IDepartmentServer departentServer)
        {
            _employeeServer = employee;
            _departentServer = departentServer;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index(int departmentId)
        {
            var department = await _departentServer.GetDepartentById(departmentId);
            ViewBag.Title = $"Employee of {department.DepartentName}";
            ViewBag.DepartentId = departmentId;
            var employees = await _employeeServer.GetEmployeesByDepartentId(departmentId);
            return View(employees);
        }
        public IActionResult Add(int departmentId)
        {
            ViewBag.Title = "Add Employee";
            return View(new Employee() { DepartmentId = departmentId });
        }
        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeServer.Add(employee);
            }
            return RedirectToAction(nameof(Index), new { departmentId = employee.DepartmentId });
        }

        public async Task<IActionResult> Fired(int employeeId)
        {
            var employee = await _employeeServer.Fired(employeeId);
            return RedirectToAction(nameof(Index), new { departmentId = employee.DepartmentId });
        }
    }
}
