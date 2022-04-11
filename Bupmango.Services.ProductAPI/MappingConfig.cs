using AutoMapper;
using Bupmango.Services.ProductAPI.Models;
using Bupmango.Services.ProductAPI.Models.Dtos;

namespace Bupmango.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
