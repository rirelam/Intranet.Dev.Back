using System;
using System.Collections.Generic;
using System.Text;
using Hsa.Intranet.All.Localization;
using Volo.Abp.Application.Services;

namespace Hsa.Intranet.All;

/* Inherit your application services from this class.
 */
public abstract class AllAppService : ApplicationService
{
    protected AllAppService()
    {
        LocalizationResource = typeof(AllResource);
    }
}
