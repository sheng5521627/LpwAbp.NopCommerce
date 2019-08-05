using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LpwAbp.Nopcommerce.Localization
{
    public static class NopcommerceLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NopcommerceConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NopcommerceLocalizationConfigurer).GetAssembly(),
                        "LpwAbp.Nopcommerce.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
