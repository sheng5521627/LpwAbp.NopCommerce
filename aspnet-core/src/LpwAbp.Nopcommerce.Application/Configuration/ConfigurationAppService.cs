using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LpwAbp.Nopcommerce.Configuration.Dto;

namespace LpwAbp.Nopcommerce.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NopcommerceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
