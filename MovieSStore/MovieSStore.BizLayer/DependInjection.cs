using Microsoft.Extensions.DependencyInjection;
using MovieSStore.BizLayer.Services;
using MovieSStore.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSStore.BizLayer
{
    public static class DependInjection
    {
        public static IServiceCollection

            AddBusinessDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IMovieRepository, MovieService>();

            return services;
        }

    }
}
