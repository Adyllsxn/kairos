namespace Kairos.Application.Abstractions.Interfaces
{
    public interface ITipoEventoService
    {
        Task<ResponseModel<List<GetTipoEventosDto>>> GetAllAsync(CancellationToken token);
        Task<ResponseModel<GetTipoEventoByIdDto>> GetByIdAsync(int tipoEventoId, CancellationToken token);
        Task<ResponseModel<List<SearchTipoEventoDto>>> SearchAsync(string expression, CancellationToken token);
        Task<ResponseModel<GetTipoEventosDto>> CreateAsync(CreateTipoEventoDto create, CancellationToken token);
        Task<ResponseModel<bool>> DeleteAsync(DeleteTipoEventoDto dto, CancellationToken token);
        Task<ResponseModel<GetTipoEventosDto>> UpdateAsync(UpdateTipoEventoDto dto, CancellationToken token);
    }
}