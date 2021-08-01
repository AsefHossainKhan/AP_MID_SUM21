using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int id { get; set; }
        public System.DateTime created_at { get; set; }
        public string status { get; set; }
        public Nullable<double> amount { get; set; }


        public ICollection<ProductOrderModel> productorders { get; set; }
    }
}
