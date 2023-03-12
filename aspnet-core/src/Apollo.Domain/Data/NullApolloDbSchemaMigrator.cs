using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Apollo.Data;

/* This is used if database provider does't define
 * IApolloDbSchemaMigrator implementation.
 */
public class NullApolloDbSchemaMigrator : IApolloDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
