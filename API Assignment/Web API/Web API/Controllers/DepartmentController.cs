using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/Department/Names")]
        [HttpGet]
        public List<String> GetNames()
        {
            return DepartmentService.GetDepartmentNames();
        }

        [Route("api/Department/GetAll")]
        [HttpGet]
        public List<DepartmentModel> GetAllDepartments()
        {
            return DepartmentService.GetDepartments();
        }

        [Route("api/Department/Add")]
        [HttpPost]
        public void Add(DepartmentModel dept)
        {
            DepartmentService.AddDepartment(dept);
        }
    }
}
