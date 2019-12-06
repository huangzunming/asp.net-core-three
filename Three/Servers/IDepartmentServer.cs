using System.Collections.Generic;
using System.Threading.Tasks;
using Three.Model;

namespace Three.Servers
{
    public interface IDepartmentServer
    {
        /// <summary>
        /// 获取所有部门信息列表
        /// </summary>
        /// <returns>返回部门信息列表</returns>
        Task<IEnumerable<Department>> GetALL();
        /// <summary>
        /// 通过部门编号获取部门信息实体
        /// </summary>
        /// <param name="id">部门编号</param>
        /// <returns>返回部门实体</returns>
        Task<Department> GetDepartentById(int id);
        /// <summary>
        /// 新增部门信息
        /// </summary>
        /// <param name="departent">部门实体对象</param>
        /// <returns></returns>
        Task Add(Department departent);
    }
}
