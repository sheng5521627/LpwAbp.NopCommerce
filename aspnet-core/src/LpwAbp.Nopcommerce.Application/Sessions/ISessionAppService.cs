using System.Threading.Tasks;
using Abp.Application.Services;
using LpwAbp.Nopcommerce.Sessions.Dto;

namespace LpwAbp.Nopcommerce.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
