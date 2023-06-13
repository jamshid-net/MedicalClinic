using Application.Services;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class RegisteriServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<ITelegramService, TelegramService>();
            return services;
        }
    }
}