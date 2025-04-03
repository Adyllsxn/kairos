namespace Kairos.Presentation.Infrastructure.Extensions;
public static class AppExtension
{
    public static void UseArchitectureExtensions (this WebApplication app)
    {
        app.Run();
    }
}
