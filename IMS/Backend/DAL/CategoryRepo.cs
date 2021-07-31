using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static IMSEntities context;

        static CategoryRepo()
        {
            context = new IMSEntities();
        }

        public static List<category> GetAllCategories()
        {
            return context.categories.ToList();
        }
    }
}
