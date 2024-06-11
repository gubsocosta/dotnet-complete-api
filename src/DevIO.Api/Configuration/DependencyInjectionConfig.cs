using DevIO.Business.Interfaces;
using DevIO.Data.Context;
using DevIO.Data.Repository;

namespace DevIO.Api.Configuration;

public static class DependencyInjectionConfig
{
    public static WebApplicationBuilder ResolveDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<MeuDbContext>();
        builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        
        return builder;
    }
}
