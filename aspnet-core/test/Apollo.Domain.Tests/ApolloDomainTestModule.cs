using Apollo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Apollo;

[DependsOn(
    typeof(ApolloEntityFrameworkCoreTestModule)
    )]
public class ApolloDomainTestModule : AbpModule
{

}
