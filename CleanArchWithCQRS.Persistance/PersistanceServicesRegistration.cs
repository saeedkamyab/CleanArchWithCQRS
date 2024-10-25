using CleanArchWithCQRS.Application.Contracts.Persistance;
using CleanArchWithCQRS.Application.Contracts.Persistance.Common;
using CleanArchWithCQRS.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Persistance
{
    public static class PersistanceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProjectDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("connectionString"));
            });

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IPhoneNumberRepository, PhoneNumberRepository>();

            return services;
        }
    }
}
