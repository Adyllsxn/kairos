namespace Kairos.Presentation.Infrastructure.Extensions.Architecture;
public static class CorsExtensions
{
    public static void AddCorsExtensions(this IServiceCollection services)
    {
        services.AddCors( x => x.AddPolicy(
            UrlCorsCommon.CorsPolicyNames,
            policy => policy.
                    WithOrigins(UrlCorsCommon.BackendUrl, UrlCorsCommon.FrontendUrl).
                    WithHeaders().
                    AllowAnyMethod().
                    AllowCredentials()
        ));
    }

    public static void UseCorsExtensions(this WebApplication app)
    {
        app.UseCors(UrlCorsCommon.CorsPolicyNames);
    }
}
