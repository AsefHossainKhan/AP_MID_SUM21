using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static IMSEntities context;
        static OrderRepo()
        {
            context = new IMSEntities();
        }

        public static List<order> GetAllOrders()
        {
            return context.orders.ToList();
        }

        public static int AddOrder(order o)
        {
            o.created_at = DateTime.Now;
            context.orders.Add(o);
            context.SaveChanges();
            return o.id;
        }

        public static void AddProductOrder(productorder p)
        {
            context.productorders.Add(p);
            context.SaveChanges();
        }

        public static List<productorder> GetOrder(int id)
        {
            return context.productorders.Where(e => e.order_id == id).ToList();
        }

        public static order GetOrderInfo(int id)
        {
            return context.orders.FirstOrDefault(e => e.id == id);
        }
    }
}
