using Microsoft.Extensions.DependencyInjection;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.ApplicationCore.Interfaces.Services;
using Planstreet.ApplicationCore.Services;
using Planstreet.Infrastructure.Context;
using Planstreet.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IDefaultFolderService, DefaultFolderService>();


            RegisterRepository(services);
            RegisterContext(services);

            return services;
        }

        public static IServiceCollection RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IDefaultFolderRepository, DefaultFolderRepository>();

            return services;
        }
        public static IServiceCollection RegisterContext(this IServiceCollection services)
        {
            services.AddScoped<PlanstreetContext>();
            return services;
        }
    }
}
