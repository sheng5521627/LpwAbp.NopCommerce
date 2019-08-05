using System.Collections.Generic;

namespace LpwAbp.Nopcommerce.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
