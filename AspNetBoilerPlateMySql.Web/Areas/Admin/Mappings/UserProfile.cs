using AspNetBoilerPlateMySql.Infrastructure.Identity.Models;
using AspNetBoilerPlateMySql.Web.Areas.Admin.Models;
using AutoMapper;

namespace AspNetBoilerPlateMySql.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}