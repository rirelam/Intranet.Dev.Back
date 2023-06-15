using Hsa.Intranet.All.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Hsa.Intranet.All.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AllController : AbpControllerBase
{
    protected AllController()
    {
        LocalizationResource = typeof(AllResource);
    }
}
