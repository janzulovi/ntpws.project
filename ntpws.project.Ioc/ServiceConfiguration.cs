using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ntpws.project.Repository;
using ntpws.project.Service;
using ntpws.project.Service.Mapping;
using System;

namespace ntpws.project.Ioc
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureApplicationServices(services);
            ConfigureRepositories(services, configuration);
        }

        private static void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddTransient<NoteService>();
            services.AddTransient<UserService>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new NoteMapperProfile());
                mc.AddProfile(new UserMapperProfile());
            });

            services.AddSingleton(mappingConfig.CreateMapper());
        }

        private static void ConfigureRepositories(IServiceCollection services, IConfiguration configuration)
        {
            var dbConfig = configuration.GetSection(nameof(DBConfig)).Get<DBConfig>();
            services.AddDbContext<ProjectDbContext>(options =>
            {
                options.UseSqlServer(dbConfig.ConnectionString);
            });

            services.AddTransient<NoteRepository>();
            services.AddTransient<UserRepository>();
        }
    }
}
