using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MicroQuiz.Services.Operations.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddMediatR(typeof(Extensions).GetTypeInfo().Assembly);

            return services;
        }
    }
}
