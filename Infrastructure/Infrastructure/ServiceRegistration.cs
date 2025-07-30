using ETicaretAPI.Application.Abstractions.Storage;
using ETicaretAPI.Application.Abstrations.Storage;
using ETicaretAPI.Infrastructure.Enums;
using ETicaretAPI.Infrastructure.Services;
using ETicaretAPI.Infrastructure.Services.Storage;
using ETicaretAPI.Infrastructure.Services.Storage.Local;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IStorageService, StorageService>();
            // Add other infrastructure services here   
        }
        public static void AddStorage<T>(this IServiceCollection services) where T: class, IStorage
        {
            services.AddScoped<IStorage, T>();
            // Add other storage services here
        }
        public static void AddStorage<T>(this IServiceCollection services, StorageType storageType ) 
        {
            switch (storageType)
            {
                case StorageType.Local:
                    services.AddScoped<IStorage,LocalStorage>();
                    break;
                case StorageType.Azure:
                    // services.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:
                    // services.AddScoped<IStorage, AWSStorage>();
                    break;
                default:
                    services.AddScoped<IStorage, LocalStorage>();
                    break;
            }
            // Add other storage services here
        }
    }
}
