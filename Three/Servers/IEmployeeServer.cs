using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Three.Model;

namespace Three.Servers
{
    public interface IEmployeeServer
    {
        /// <summary>
        /// 通过部门编号获得部门下面的所有员工列表
        /// </summary>
        /// <param name="departentId">部门编号</param>
        /// <returns>返回员工列表</returns>
        Task<IEnumerable<Employee>> GetEmployeesByDepartentId(int departentId);
        /// <summary>
        /// 通过员工编号获取员工实体
        /// </summary>
        /// <param name="id">员工编号</param>
        /// <returns>返回员工实体对象</returns>
        Task<Employee> GetEmployeeById(int id);
        /// <summary>
        /// 新增员工信息
        /// </summary>
        /// <param name="employee">员工信息实体对象</param>
        /// <returns>返回成功</returns>
        Task Add(Employee employee);
        /// <summary>
        /// 通过员工编号辞退员工
        /// </summary>
        /// <param name="id">员工编号</param>
        /// <returns>返回成功</returns>
        Task<Employee> Fired(int id);
    }
}
