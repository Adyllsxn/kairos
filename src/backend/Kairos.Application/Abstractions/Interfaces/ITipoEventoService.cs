namespace Kairos.Application.Abstractions.Interfaces
{
    public interface ITipoEventoService
    {
        Task<ResponseModel<List<GetTipoEventosDto>>> GetAllAsync(CancellationToken token);
    }
}