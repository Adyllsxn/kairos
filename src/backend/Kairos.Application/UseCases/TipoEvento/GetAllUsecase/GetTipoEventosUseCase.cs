namespace Kairos.Application.UseCases.TipoEvento.GetAllUsecase;
public class GetTipoEventosUseCase(ITipoEventoRepository repository)
{
    public async Task<ResponseModel<List<GetTipoEventosDto>>> GetAllAsync(CancellationToken token)
    {
        try
        {
            var response = await repository.GetAllAsync(token);
            
            if (!response.IsSuccess)
            {
                return new ResponseModel<List<GetTipoEventosDto>>(
                    null, 
                    response.Code, 
                    response.Message);
            }
            if (response.Data == null || !response.Data.Any())
            {
                return new ResponseModel<List<GetTipoEventosDto>>(
                    new List<GetTipoEventosDto>(), 
                    404, 
                    "Nenhum dado encontrado");
            }
            var result = response.Data.ToDTO().ToList();
            
            return new ResponseModel<List<GetTipoEventosDto>>(
                result, 
                200, 
                "Dados encontrados");
        }
        catch (Exception ex)
        {
            return new ResponseModel<List<GetTipoEventosDto>>(
                null, 
                500, 
                $"Erro ao obter tipos de evento. Erro: {ex.Message}");
        }
    }
}
