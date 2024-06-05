using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Api.Configuration;

public static class DbContextConfig
{
    public static WebApplicationBuilder AddDbContextConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<MeuDbContext>(options => {
            var connectionString = builder
                .Configuration
                .GetConnectionString("DefaultConnection");

            options.UseSqlServer(connectionString);
        });
        
        return builder;
    }
}
