namespace Kairos.Application.Services;
public class TipoEventoService(GetTipoEventosUseCase getall) : ITipoEventoService
{
    public async Task<ResponseModel<List<GetTipoEventosDto>>> GetAllAsync(CancellationToken token)
    {
        return await getall.GetAllAsync(token);
    }
}
