using System.Collections.Generic;
using System.Threading.Tasks;
using Three.Model;
using System.Linq;

namespace Three.Servers
{
    public class EmployessServer : IEmployeeServer
    {
        private readonly List<Employee> employees = new List<Employee>();
        public EmployessServer()
        {
            employees.Add(new Employee()
            {
                Id = 1,
                DepartmentId = 1,
                SurnName = "huang",
                FullName = "zunming",
                Gender = Gender.男,
            });
            employees.Add(new Employee()
            {
                Id = 2,
                DepartmentId = 1,
                SurnName = "li",
                FullName = "meili",
                Gender = Gender.女,
            });
            employees.Add(new Employee()
            {
                Id = 3,
                DepartmentId = 2,
                SurnName = "zhang",
                FullName = "xiaohu",
                Gender = Gender.女,
            });
        }

        public Task Add(Employee employee)
        {
            employee.Id = employees.Max(x => x.Id) + 1;
            employees.Add(employee);
            return Task.CompletedTask;
        }

        public Task<Employee> Fired(int id)
        {
            return Task.Run(() =>
            {
                var employee = employees.FirstOrDefault(x => x.Id == id);
                if (employee == null)
                    return null;
                employee.Fired = true;
                return employee;
            });
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            return Task.Run(() => employees.FirstOrDefault(x => x.Id == id));
        }

        public Task<IEnumerable<Employee>> GetEmployeesByDepartentId(int departentId)
        {
            return Task.Run(() => employees.Where(x => x.DepartmentId == departentId));
        }
    }
}
