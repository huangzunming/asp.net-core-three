using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Three.Model
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name = "部门名称")]
        public string DepartentName { get; set; }
        [Display(Name = "部门简介")]
        public string Introduction { get; set; }
        [Display(Name = "部门的员工人数")]
        public int EmployeeCount { get; set; }
    }
}
