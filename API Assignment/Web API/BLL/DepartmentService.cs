using DAL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepartmentService
    {
        public static List<string> GetDepartmentNames()
        {
            return DepartmentRepo.GetDepartmentNames();
        }

        public static List<DepartmentModel> GetDepartments()
        {
            var departments = DepartmentRepo.GetDepartments();
            List<DepartmentModel> departmentList = new List<DepartmentModel>();
            foreach (var department in departments)
            {
                var d = new DepartmentModel()
                {
                    ID = department.ID,
                    Name = department.Name
                };
                departmentList.Add(d);  
            }
            return departmentList;
        }

        public static void AddDepartment(DepartmentModel dept)
        {
            var d = new Department()
            {
                ID = dept.ID,
                Name = dept.Name
            };
            DepartmentRepo.AddDepartment(d);
        }
    }
}
