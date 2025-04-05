namespace Kairos.Application.UseCases.TipoEvento.GetByIdUseCase;
public class GetTipoEventoByIdUseCase(ITipoEventoRepository repository)
{
    public async Task<ResponseModel<GetTipoEventoByIdDto>> GetByIdAsync(int tipoEventoId, CancellationToken token)
    {
        try
        {
            if(tipoEventoId <= 0)
            {
                return new ResponseModel<GetTipoEventoByIdDto>(
                    null,
                    400,
                    "ID não deve ser menor que um."
                );
            }
            var response = await repository.GetByIdAsync(tipoEventoId, token);
            if (response.Data == null)
            {
                return new ResponseModel<GetTipoEventoByIdDto>(
                    null, 
                    404, 
                    "Nenhum dado encontrado");
            }
            var result = response.Data.ToDTO();
            
            return new ResponseModel<GetTipoEventoByIdDto>(
                result, 
                200, 
                "Dados encontrados");
        }
        catch(Exception ex)
        {
            return new ResponseModel<GetTipoEventoByIdDto>(
                null, 
                500, 
                $"Erro ao obter tipos de evento. Erro: {ex.Message}");
        }
    }
}
