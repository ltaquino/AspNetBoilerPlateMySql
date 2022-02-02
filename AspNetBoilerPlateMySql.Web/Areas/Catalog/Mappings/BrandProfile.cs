using AspNetBoilerPlateMySql.Application.Features.Brands.Commands.Create;
using AspNetBoilerPlateMySql.Application.Features.Brands.Commands.Update;
using AspNetBoilerPlateMySql.Application.Features.Brands.Queries.GetAllCached;
using AspNetBoilerPlateMySql.Application.Features.Brands.Queries.GetById;
using AspNetBoilerPlateMySql.Web.Areas.Catalog.Models;
using AutoMapper;

namespace AspNetBoilerPlateMySql.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}