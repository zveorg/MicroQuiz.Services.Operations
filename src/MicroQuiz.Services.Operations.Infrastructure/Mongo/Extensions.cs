using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using MicroQuiz.Services.Operations.Core.Repositories;
using MicroQuiz.Services.Operations.Infrastructure.Mongo.Repositories;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson;
using Microsoft.AspNetCore.Builder;

namespace MicroQuiz.Services.Operations.Infrastructure.Mongo
{
    public static class Extensions
    {
        public static IServiceCollection AddMongo(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoOptions>(options =>
            {
                configuration.GetSection("Mongo").Bind(options);
            });

            services.AddSingleton<MongoClient>(c =>
            {
                var options = c.GetService<IOptions<MongoOptions>>();
                return new MongoClient(options.Value.ConnectionString);
            });

            services.AddScoped<IMongoDatabase>(c =>
            {
                var options = c.GetService<IOptions<MongoOptions>>();
                var client = c.GetService<MongoClient>();
                return client.GetDatabase(options.Value.Database);
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOperationRepository, OperationRepository>();

            return services;
        }

        public static IApplicationBuilder UseMongo(this IApplicationBuilder app)
        {
            var pack = new ConventionPack { new EnumRepresentationConvention(BsonType.String) };
            ConventionRegistry.Register("EnumStringConvention", pack, t => true);

            return app;
        }
    }
}
