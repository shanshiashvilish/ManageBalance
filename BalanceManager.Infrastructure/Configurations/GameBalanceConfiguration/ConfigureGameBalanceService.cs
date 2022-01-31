using BalanceManager.Application.Services;
using BalanceManager.Core.GameBalance;
using Balances;
using Microsoft.Extensions.DependencyInjection;

namespace BalanceManager.Infrastructure.Configurations.GameBalanceConfiguration
{
    public static class ConfigureGameBalanceService
    {
        public static IServiceCollection AddGameBalanceService(this IServiceCollection services)
        {
            services.AddSingleton<GameBalanceManager>();
            services.AddScoped<IGameBalanceService, GameBalanceService>();

            return services;
        }
    }
}
