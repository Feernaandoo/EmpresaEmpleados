using Contracts;
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmpresaEmpleados.Extensions
{
    public static class ServiceExtensions
    {
        // Configuración básica de CORS, permite que todas las solicitudes de todos los orígenes se envíen a nuestra API. 
        //En un entorno de producción debe ser lo más restrictivo posible.
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });

        // Configuración de integración de IIS que eventualmente nos ayudará con la implementación de IIS.
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
        });

        // Agregado del servicio de logger dentro del Contenedor IOC.
        public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddScoped<ILoggerManager, LoggerManager>();

        // Agregado de la clase RepositoryContext en el contenedor IOC
        public static void ConfigureSqlContext(this IServiceCollection services,
        IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(opts =>
        opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
