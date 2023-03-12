using Apollo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Apollo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ApolloController : AbpControllerBase
{
    protected ApolloController()
    {
        LocalizationResource = typeof(ApolloResource);
    }
}
