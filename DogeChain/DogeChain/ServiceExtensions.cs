using DogeChain.JsonApi.Address;
using DogeChain.JsonApi.Transactions;
using DogeChain.SimpleApi.Platform;
using Microsoft.Extensions.DependencyInjection;

namespace DogeChain
{
    /// <summary>
    /// Service Extensions
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Include NuGet to ASP.NET Core pipeline
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDogeChainServices(this IServiceCollection services)
        {
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<SimpleApi.Address.IAddressService, SimpleApi.Address.AddressService>();
            services.AddScoped<IDogechainInfoService, DogechainInfoService>();
            return services;
        }
    }
}