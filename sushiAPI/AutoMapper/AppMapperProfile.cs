using AutoMapper;
using sushiAPI.DTOs;
using sushiAPI.Entities;

namespace sushiAPI.AutoMapper
{
    public class AppMapperProfile : Profile
    {
        public AppMapperProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}