using AspNetBoilerPlateMySql.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace AspNetBoilerPlateMySql.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}