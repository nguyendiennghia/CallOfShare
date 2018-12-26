using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CallOfShare.Localization
{
    public static class CallOfShareLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CallOfShareConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CallOfShareLocalizationConfigurer).GetAssembly(),
                        "CallOfShare.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
