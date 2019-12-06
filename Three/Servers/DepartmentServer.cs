using System.Collections.Generic;
using System.Threading.Tasks;
using Three.Model;
using System.Linq;

namespace Three.Servers
{
    public class DepartmentServer : IDepartmentServer
    {
        private readonly List<Department> departents = new List<Department>();
        public DepartmentServer()
        {
            departents.Add(new Department
            {
                Id = 1,
                DepartentName = "HR",
                Introduction = "shanhai",
                EmployeeCount = 16
            });
            departents.Add(new Department
            {
                Id = 2,
                DepartentName = "R&D",
                Introduction = "baijing",
                EmployeeCount = 52
            });
            departents.Add(new Department
            {
                Id = 3,
                DepartentName = "Sales",
                Introduction = "china",
                EmployeeCount = 200
            });

        }

        public Task Add(Department departent)
        {
            departent.Id = departents.Max(x => x.Id) + 1;
            departents.Add(departent);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Department>> GetALL()
        {
            return Task.Run(() => departents.AsEnumerable());
        }

        public Task<Department> GetDepartentById(int id)
        {
            return Task.Run(() => departents.FirstOrDefault(x => x.Id == id));
        }
    }
}
