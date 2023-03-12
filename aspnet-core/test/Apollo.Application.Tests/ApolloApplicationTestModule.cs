using Volo.Abp.Modularity;

namespace Apollo;

[DependsOn(
    typeof(ApolloApplicationModule),
    typeof(ApolloDomainTestModule)
    )]
public class ApolloApplicationTestModule : AbpModule
{

}
