namespace Kairos.Application.UseCases.TipoEvento.CreateUseCase;
public class CreateTipoEventoUseCase(ITipoEventoRepository repository, IUnitOfWork unitOfWork)
{
    public async Task<ResponseModel<GetTipoEventosDto>> CreateAsync(CreateTipoEventoDto create, CancellationToken token)
    {
        try
        {
            var entity = create.ToEntity();
            var response = await repository.CreateAsync(entity, token);
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
                $"Erro ao criar tipos de eventos. Erro: {ex.Message}");
        }
    }
}