namespace Kairos.Presentation.Infrastructure.Extensions;
public static class AppExtension
{
    public static void UseArchitectureExtensions (this WebApplication app)
    {
        app.UseHttpsRedirection();
        app.UseSwaggerExtensions();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
