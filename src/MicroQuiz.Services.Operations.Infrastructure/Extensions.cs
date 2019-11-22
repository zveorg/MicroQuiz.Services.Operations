using MicroQuiz.Services.Operations.Infrastructure.Mongo;
using MicroQuiz.Services.Operations.Infrastructure.RabbitMq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroQuiz.Services.Operations.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories()
                .AddRabbitMq(configuration)
                .AddMongo(configuration);

            return services;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app
                .UseRabbit()
                .UseMongo();

            return app;
        }
    }
}
