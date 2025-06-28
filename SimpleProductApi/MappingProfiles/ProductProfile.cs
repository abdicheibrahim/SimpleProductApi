using AutoMapper;
using SimpleProductApi.DTOs;
using SimpleProductApi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleProductApi.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
