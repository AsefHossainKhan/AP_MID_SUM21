using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductModel> GetAllProducts()
        {
            var products = ProductRepo.GetAllProducts();
            var data = AutoMapper.Mapper.Map<List<product>, List<ProductModel>>(products);
            return data;
        }

        public static void AddProduct(ProductModel p)
        {
            var data = AutoMapper.Mapper.Map<ProductModel, product>(p);
            ProductRepo.AddProduct(data);
        }
    }
}
