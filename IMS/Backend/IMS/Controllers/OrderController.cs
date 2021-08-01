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
    public class OrderController : ApiController
    {

        [Route("api/Order/GetAll")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {
            return OrderService.GetAllOrders();
        }

        //[Route("api/Order/Add")]
        //[HttpPost]
        //public int AddOrder(OrderModel o)
        //{
        //    return OrderService.AddOrder(o);
        //}


        [Route("api/Order/Place")]
        [HttpPost]
        public void OrderPlace(List<ProductOrderModel> cart)
        {
            OrderModel o = new OrderModel();
            o.status = "Pending";
            double total = 0;
            foreach (var item in cart)
            {
                total += (item.product_price * item.product_quantity);
            }
            o.amount = total;
            int orderId = OrderService.AddOrder(o);
            foreach(var item in cart)
            {
                item.order_id = orderId;
                OrderService.AddProductOrder(item);
            }
        }

        [Route("api/Order/info/{id}")]
        [HttpGet]
        public List<ProductOrderModel> GetOrder(int id)
        {
            return OrderService.GetOrder(id);
        }

        [Route("api/Order/{id}")]
        [HttpGet]
        public OrderModel GetOrderInfo(int id)
        {
            return OrderService.GetOrderInfo(id);
        }

    }
}
