using AspNetBoilerPlateMySql.Application.Features.Products.Commands.Create;
using AspNetBoilerPlateMySql.Application.Features.Products.Queries.GetAllCached;
using AspNetBoilerPlateMySql.Application.Features.Products.Queries.GetAllPaged;
using AspNetBoilerPlateMySql.Application.Features.Products.Queries.GetById;
using AspNetBoilerPlateMySql.Domain.Entities.Catalog;
using AutoMapper;

namespace AspNetBoilerPlateMySql.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}