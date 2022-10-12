using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.InterfaceRepositry;
using WebAPI.Repository;
using WebAPI.ServiceInterface;
using WebAPI.Services;

namespace WebAPI.Service_Extension
{
    public static class Extensions
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration config)
        {

            #region Configure Services
            services.AddHttpContextAccessor();
            services.AddTransient<IDepartmentService, DepartmentService>();

            #endregion

            #region Configure Repositories
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();

            #endregion

            #region Configure Services
            services.AddHttpContextAccessor();
            services.AddTransient<IMarkService, MarkService>();

            #endregion

            #region Configure Repositories
            services.AddTransient<IMarkRepository, MarkRepository>();

            #endregion


            #region Configure Services
            services.AddHttpContextAccessor();
            services.AddTransient<IDetailService, DetailService>();

            #endregion

            #region Configure Repositories
            services.AddTransient<IDetailRepository, DetailRepository>();

            #endregion
        }
    }
}
