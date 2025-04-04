namespace Kairos.Application.UseCases.TipoEvento.GetAllUsecase;
public static class GetTipoEventosDtoExpression
{
    public static GetTipoEventosDto ToDTO (this TipoEventoEntity entity)
    {
        return new GetTipoEventosDto
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<GetTipoEventosDto> ToDTO(this IEnumerable<TipoEventoEntity> dto)
    {
        return dto.Select(entity => entity.ToDTO());
    }
}
