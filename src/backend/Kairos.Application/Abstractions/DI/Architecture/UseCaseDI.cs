namespace Kairos.Application.Abstractions.DI.Architecture;
public static class UseCaseDI
{
    public static void AddUseCase(this IServiceCollection service)
    {
        #region <TipoEventos>
            service.AddScoped<GetTipoEventosUseCase>();
            service.AddScoped<GetTipoEventoByIdUseCase>();
            service.AddScoped<SearchTipoEventoUseCase>();
            service.AddScoped<CreateTipoEventoUseCase>();
            service.AddScoped<DeleteTipoEventoUseCase>();
            service.AddScoped<UpdateTipoEventoUseCase>();
        #endregion
        
    }
}
