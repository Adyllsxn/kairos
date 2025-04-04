namespace Kairos.Application.Abstractions.DI;
public static class ApplicationDI
{
    public static void AddApplicationDI(this IServiceCollection service)
    {
        service.AddUseCase();
        service.AddService();
    }
}
