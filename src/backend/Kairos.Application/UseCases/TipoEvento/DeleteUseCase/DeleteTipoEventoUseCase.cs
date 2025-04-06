namespace Kairos.Application.UseCases.TipoEvento.DeleteUseCase;
public class DeleteTipoEventoUseCase(ITipoEventoRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<ResponseModel<bool>> DeleteAsync(DeleteTipoEventoDto dto, CancellationToken token)
    {
        try
        {
            var response = await repository.DeleteAsync(dto.Id, token);
            await unitOfWork.CommitAsync();
            return new ResponseModel<bool>(
                response.Data,
                response.Code,
                response.Message
            );
        }
        catch(Exception ex)
        {
            return new ResponseModel<bool>(
                false,
                500,
                $"Erro ao deletar tipos de evento. Erro: {ex.Message}"
            );
        }
    }
}
