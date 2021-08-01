using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class OrderService
    {
        public static List<OrderModel> GetAllOrders()
        {
            var orders = OrderRepo.GetAllOrders();
            var data = AutoMapper.Mapper.Map<List<order>, List<OrderModel>>(orders);
            return data;
        }

        public static int AddOrder(OrderModel o)
        {
            var order = AutoMapper.Mapper.Map<OrderModel, order>(o);
            return OrderRepo.AddOrder(order);
        }

        public static void AddProductOrder(ProductOrderModel item)
        {
            var productOrder = AutoMapper.Mapper.Map<ProductOrderModel, productorder>(item);
            OrderRepo.AddProductOrder(productOrder);
        }

        public static List<ProductOrderModel> GetOrder(int id)
        {
            var productOrders = OrderRepo.GetOrder(id);
            return AutoMapper.Mapper.Map<List<productorder>, List<ProductOrderModel>>(productOrders);
        }

        public static OrderModel GetOrderInfo(int id)
        {
            var order = OrderRepo.GetOrderInfo(id);
            return AutoMapper.Mapper.Map<order, OrderModel>(order);
        }
    }
}
