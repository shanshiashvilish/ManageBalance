using Microsoft.Extensions.DependencyInjection;
using BalanceManager.Core.CasinoBalance;
using BalanceManager.Application.Services;

namespace BalanceManager.Infrastructure.Configurations.CasinoBalanceConfiguration
{
    public static class ConfigureCasinoBalanceService
    {
        public static IServiceCollection AddCasinoBalanceService(this IServiceCollection services)
        {
            services.AddScoped<ICasinoBalanceService, CasinoBalanceService>();

            return services;
        }

    }
}
