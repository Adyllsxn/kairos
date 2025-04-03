namespace Kairos.Presentation.Infrastructure.Extensions;
public static class BuildExtension
{
    public static void AddArchitectureExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddInfrastructureDI(builder.Configuration);
    }
}
