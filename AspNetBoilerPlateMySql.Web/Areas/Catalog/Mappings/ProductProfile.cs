using AspNetBoilerPlateMySql.Application.Features.Products.Commands.Create;
using AspNetBoilerPlateMySql.Application.Features.Products.Commands.Update;
using AspNetBoilerPlateMySql.Application.Features.Products.Queries.GetAllCached;
using AspNetBoilerPlateMySql.Application.Features.Products.Queries.GetById;
using AspNetBoilerPlateMySql.Web.Areas.Catalog.Models;
using AutoMapper;

namespace AspNetBoilerPlateMySql.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}