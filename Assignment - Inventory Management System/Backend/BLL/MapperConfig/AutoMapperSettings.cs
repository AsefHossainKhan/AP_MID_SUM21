using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<CategoryModel, category>();
            CreateMap<ProductModel, product>();
            CreateMap<OrderModel, order>();
            CreateMap<ProductOrderModel, productorder>();
        }
    }
}
