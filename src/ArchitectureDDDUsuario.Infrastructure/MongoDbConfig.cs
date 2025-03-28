using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectureDDDUsuario.Infrastructure;

public static class MongoDbConfig
{
    public static void AddMongoDb(this IServiceCollection services, IConfiguration configuration)
    {
        var mongoConnectionString = configuration["MongoDB:ConnectionString"];
        var databaseName = configuration["MongoDB:DatabaseName"];

        var mongoClient = new MongoClient(mongoConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(databaseName);

        services.AddSingleton<IMongoClient>(mongoClient);
        services.AddSingleton<IMongoDatabase>(mongoDatabase);
    }
}
