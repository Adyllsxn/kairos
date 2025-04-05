namespace Kairos.Application.Abstractions.Interfaces
{
    public interface ITipoEventoService
    {
        Task<ResponseModel<List<GetTipoEventosDto>>> GetAllAsync(CancellationToken token);
        Task<ResponseModel<GetTipoEventoByIdDto>> GetByIdAsync(int tipoEventoId, CancellationToken token);
        Task<ResponseModel<List<SearchTipoEventoDto>>> SearchAsync(string expression, CancellationToken token);
    }
}