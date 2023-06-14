using Application.Services;
using Infrastructure.DataAccess;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class RegisteriServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ClinicDbContext>(dbContextOption =>
        dbContextOption.UseNpgsql(configuration.GetConnectionString("DbConnection")));

        services.AddSingleton<ITelegramService, TelegramService>();
        return services;
    }
}