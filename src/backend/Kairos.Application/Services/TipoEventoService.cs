namespace Kairos.Application.Services;
public class TipoEventoService(GetTipoEventosUseCase getall, GetTipoEventoByIdUseCase getbyid, SearchTipoEventoUseCase search, CreateTipoEventoUseCase creates, DeleteTipoEventoUseCase delete, UpdateTipoEventoUseCase update) : ITipoEventoService
{
    public async Task<ResponseModel<GetTipoEventosDto>> CreateAsync(CreateTipoEventoDto create, CancellationToken token)
    {
        return await creates.CreateAsync(create, token);
    }

    public async Task<ResponseModel<bool>> DeleteAsync(DeleteTipoEventoDto dto, CancellationToken token)
    {
        return await delete.DeleteAsync(dto,token);
    }

    public async Task<ResponseModel<GetTipoEventosDto>> UpdateAsync(UpdateTipoEventoDto dto, CancellationToken token)
    {
        return await update.UpdateAsync(dto, token);
    }

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
