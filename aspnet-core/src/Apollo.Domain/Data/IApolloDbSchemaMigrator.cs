using System.Threading.Tasks;

namespace Apollo.Data;

public interface IApolloDbSchemaMigrator
{
    Task MigrateAsync();
}
