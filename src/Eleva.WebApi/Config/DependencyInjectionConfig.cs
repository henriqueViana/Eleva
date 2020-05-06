using Eleva.Data.Context;
using Eleva.Data.Repository;
using Eleva.Domain.Interfaces;
using Eleva.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eleva.WebApi.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<ElevaDbContext>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<ISchoolService, SchoolService>();

            services.AddScoped<IAddressRepository, AddressRepository>();
            
            services.AddScoped<IStudentClassRepository, StudentClassRepository>();
            services.AddScoped<IStudentClassService, StudentClassService>();

            return services;

        }
    }
}
