using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TeDuEcommer;

[Dependency(ReplaceServices = true)]
public class TeDuEcommerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TeDuEcommer";
}
