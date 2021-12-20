using Lab.App.Extensions;
using Lab.Business.Interfaces;
using Lab.Business.Notifications;
using Lab.Business.Services;
using Lab.Data.Contexts;
using Lab.Data.Repositories;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace Lab.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDepencias(this IServiceCollection services)
        {
            services.AddScoped<LabDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
