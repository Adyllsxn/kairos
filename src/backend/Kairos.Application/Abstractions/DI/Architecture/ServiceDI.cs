namespace Kairos.Application.Abstractions.DI.Architecture;
public static class ServiceDI
{
    public static void AddService(this IServiceCollection service)
    {
        service.AddScoped<ITipoEventoService, TipoEventoService>();
    }
}
