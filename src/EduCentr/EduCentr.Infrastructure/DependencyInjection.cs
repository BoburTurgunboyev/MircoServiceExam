using EduCentr.Application.Absreaction;
using EduCentr.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IAppDbConnect, AppDbConnent>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnections"));
            });

            return services;
        }
    }
}
