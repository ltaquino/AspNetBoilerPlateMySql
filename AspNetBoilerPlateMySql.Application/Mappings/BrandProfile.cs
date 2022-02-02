using AspNetBoilerPlateMySql.Application.Features.Brands.Commands.Create;
using AspNetBoilerPlateMySql.Application.Features.Brands.Queries.GetAllCached;
using AspNetBoilerPlateMySql.Application.Features.Brands.Queries.GetById;
using AspNetBoilerPlateMySql.Domain.Entities.Catalog;
using AutoMapper;

namespace AspNetBoilerPlateMySql.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}