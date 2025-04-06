namespace Kairos.Application.UseCases.TipoEvento.SearchUseCase;
public class SearchTipoEventoUseCase(ITipoEventoRepository repository)
{
    public async Task<ResponseModel<List<SearchTipoEventoDto>>> SearchAsync(string expression, CancellationToken token)
    {
        try
        {
            if(expression == null)
            {
                return new ResponseModel<List<SearchTipoEventoDto>>(
                    null, 
                    400, 
                    "Parâmetro não deve estar vazio.");
            }
            var response = await repository.SearchAsync(x => x.Nome.Contains(expression),string.Empty,token);

            if (response.Data == null || !response.Data.Any())
            {
                return new ResponseModel<List<SearchTipoEventoDto>>(
                    null, 
                    404, 
                    "Nenhum dado encontrado");
            }
            var result = response.Data.ToDTOSearchTipoEvento().ToList();
            
            return new ResponseModel<List<SearchTipoEventoDto>>(
                result, 
                200, 
                "Dados encontrados");
        }
        catch (Exception ex)
        {
            return new ResponseModel<List<SearchTipoEventoDto>>(
                null, 
                500, 
                $"Erro ao pesquisar tipos de evento. Erro: {ex.Message}");
        }

    }
}
