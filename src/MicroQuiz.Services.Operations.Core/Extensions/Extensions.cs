using AutoMapper;
using MicroQuiz.Services.Operations.Core.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace MicroQuiz.Services.Operations.Core.Extensions
{
    public static class Extensions
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new OperationProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}
