namespace Kairos.Application.UseCases.TipoEvento.GetAllUsecase;
public static class GetTipoEventosDtoExtensions
{
    public static GetTipoEventosDto ToDTOGetTipoEventos (this TipoEventoEntity entity)
    {
        return new GetTipoEventosDto
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<GetTipoEventosDto> ToDTOGetTipoEventos(this IEnumerable<TipoEventoEntity> dto)
    {
        return dto.Select(entity => entity.ToDTOGetTipoEventos());
    }
}
