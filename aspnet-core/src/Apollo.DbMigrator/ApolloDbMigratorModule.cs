using Apollo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Apollo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ApolloEntityFrameworkCoreModule),
    typeof(ApolloApplicationContractsModule)
    )]
public class ApolloDbMigratorModule : AbpModule
{

}
