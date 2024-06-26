using DevIO.Business.Interfaces;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;

namespace DevIO.Api.Configuration;

public static class DependencyInjectionConfig
{
    public static WebApplicationBuilder ResolveDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<MeuDbContext>();
        builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
        
        builder.Services.AddScoped<INotificador, Notificador>();
        builder.Services.AddScoped<IFornecedorService, FornecedorService>();
        builder.Services.AddScoped<IProdutoService, ProdutoService>();
        
        return builder;
    }
}
