using AutoMapper;
using Mango.Services.ProductAPI.Model;
using Mango.Services.ProductAPI.Model.Dtos;

namespace Mango.Services.ProductAPI
{
    public class MappingCongfiguration
    {
        public static MapperConfiguration RegisterMapp()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDtos, Product>();
                config.CreateMap<Product, ProductDtos>();
            });
            return mappingConfig;
        }
    }
}
