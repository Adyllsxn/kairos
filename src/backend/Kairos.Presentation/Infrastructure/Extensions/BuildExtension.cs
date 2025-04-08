namespace Kairos.Presentation.Infrastructure.Extensions;
public static class BuildExtension
{
    public static void AddArchitectureExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddCorsExtensions();
        builder.Services.AddSwaggerExtensions();
        builder.Services.AddInfrastructureDI(builder.Configuration);
        builder.Services.AddApplicationDI();
    }
}
