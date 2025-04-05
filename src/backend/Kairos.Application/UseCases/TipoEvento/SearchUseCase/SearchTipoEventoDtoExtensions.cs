namespace Kairos.Application.UseCases.TipoEvento.SearchUseCase;
public static class SearchTipoEventoDtoExtensions
{
    public static SearchTipoEventoDto ToDTO (this TipoEventoEntity entity)
    {
        return new SearchTipoEventoDto
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<SearchTipoEventoDto> ToDTO(this IEnumerable<TipoEventoEntity> dto)
    {
        return dto.Select(entity => entity.ToDTO());
    }
}
