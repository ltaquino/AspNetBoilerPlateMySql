using System.Threading.Tasks;

namespace AspNetBoilerPlateMySql.Web.Abstractions
{
    public interface IViewRenderService
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}