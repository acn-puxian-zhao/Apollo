using System;
using System.Collections.Generic;
using System.Text;
using Apollo.Localization;
using Volo.Abp.Application.Services;

namespace Apollo;

/* Inherit your application services from this class.
 */
public abstract class ApolloAppService : ApplicationService
{
    protected ApolloAppService()
    {
        LocalizationResource = typeof(ApolloResource);
    }
}
