using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ProductOrderModel
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int order_id { get; set; }
        public double product_price { get; set; }
        public int product_quantity { get; set; }

        public string product_name { get; set; }
    }
}
