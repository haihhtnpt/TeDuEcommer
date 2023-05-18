using System;
using System.Collections.Generic;
using System.Text;
using TeDuEcommer.Localization;
using Volo.Abp.Application.Services;

namespace TeDuEcommer;

/* Inherit your application services from this class.
 */
public abstract class TeDuEcommerAppService : ApplicationService
{
    protected TeDuEcommerAppService()
    {
        LocalizationResource = typeof(TeDuEcommerResource);
    }
}
