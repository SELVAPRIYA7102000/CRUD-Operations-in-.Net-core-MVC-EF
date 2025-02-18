﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SampleCore.Core.IRepositories;
using SampleCore.Core.IServices;
using SampleCore.Repositories.Repositories;
using SampleCore.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCore.Utility
{
    public class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //for accessing the http context by interface in view level
            #region Http context
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
            //for service accesssing
            #region Service

            services.AddScoped<IPersonServices, PersonServices>();
            #endregion
            //for database accessing 
            #region Repository

            services.AddScoped<IPersonRepository, PersonRepository>();

            #endregion


        }
    }
}
