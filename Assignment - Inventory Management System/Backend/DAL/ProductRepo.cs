using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static IMSEntities context;
        static ProductRepo()
        {
            context = new IMSEntities();
        }

        public static List<product> GetAllProducts()
        {
            return context.products.ToList();
        }

        public static void AddProduct(product p)
        {
            p.created_at = DateTime.Now;
            p.created_by = "asef";
            context.products.Add(p);
            context.SaveChanges();
        }
    }
}
