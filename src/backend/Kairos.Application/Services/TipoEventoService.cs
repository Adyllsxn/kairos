namespace Kairos.Application.Services;
public class TipoEventoService(GetTipoEventosUseCase getall, GetTipoEventoByIdUseCase getbyid, SearchTipoEventoUseCase search) : ITipoEventoService
{
    public async Task<ResponseModel<List<GetTipoEventosDto>>> GetAllAsync(CancellationToken token)
    {
        return await getall.GetAllAsync(token);
    }

    public async Task<ResponseModel<GetTipoEventoByIdDto>> GetByIdAsync(int tipoEventoId, CancellationToken token)
    {
        return await getbyid.GetByIdAsync(tipoEventoId, token);
    }

    public async Task<ResponseModel<List<SearchTipoEventoDto>>> SearchAsync(string expression, CancellationToken token)
    {
        return await search.SearchAsync(expression, token);
    }
}
