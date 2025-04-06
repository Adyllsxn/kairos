namespace Kairos.Application.UseCases.TipoEvento.UpdateUseCase;
public class UpdateTipoEventoUseCase(ITipoEventoRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<ResponseModel<GetTipoEventosDto>> UpdateAsync(UpdateTipoEventoDto dto, CancellationToken token)
    {
        try
        {
            var entity = dto.ToEntity();
            var response = await repository.UpdateAsync(entity, token);
            await unitOfWork.CommitAsync();

            return new ResponseModel<GetTipoEventosDto>(
                response.Data?.ToDTOGetTipoEventos(),
                response.Code,
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new ResponseModel<GetTipoEventosDto>(
                null, 
                500, 
                $"Erro ao editar tipos de eventos. Erro: {ex.Message}");
        }
    }
}
