using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Apollo;

[Dependency(ReplaceServices = true)]
public class ApolloBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Apollo";
}
