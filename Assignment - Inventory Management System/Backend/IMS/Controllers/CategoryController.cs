using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace IMS.Controllers
{
    public class CategoryController : ApiController
    {
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryModel> GetAllCategories()
        {
            return CategoryService.GetAllCategories();
        }

        [Route("api/Category/Add")]
        [HttpPost]
        public void AddCategory(CategoryModel c)
        {
            CategoryService.AddCategory(c);
        }
    }
}
