using System.Threading.Tasks;
using LpwAbp.Nopcommerce.Configuration.Dto;

namespace LpwAbp.Nopcommerce.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
