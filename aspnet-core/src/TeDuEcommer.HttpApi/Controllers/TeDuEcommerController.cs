using TeDuEcommer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TeDuEcommer.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TeDuEcommerController : AbpControllerBase
{
    protected TeDuEcommerController()
    {
        LocalizationResource = typeof(TeDuEcommerResource);
    }
}
