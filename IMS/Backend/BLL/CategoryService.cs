using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class CategoryService
    {
        public static List<CategoryModel> GetAllCategories()
        {
            var categories = CategoryRepo.GetAllCategories();
            var data = AutoMapper.Mapper.Map<List<category>, List<CategoryModel>>(categories);
            //List<CategoryModel> categoryList = new List<CategoryModel>();
            //foreach (var category in categories)
            //{
            //    var c = new CategoryModel()
            //    {
            //        id = category.id,
            //        name = category.name
            //    };
            //    categoryList.Add(c);
            //}
            //return categoryList;

            return data;
        }

        public static void AddCategory(CategoryModel category)
        {
            var data = AutoMapper.Mapper.Map<CategoryModel, category>(category);
            CategoryRepo.AddCategory(data);
        }
    }
}
