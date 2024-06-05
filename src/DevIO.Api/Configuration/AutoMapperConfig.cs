namespace DevIO.Api.Configuration;

public static class AutoMapperConfig
{
    public static WebApplicationBuilder AddAutoMapperConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(typeof(Program));

        return builder;
    }
}