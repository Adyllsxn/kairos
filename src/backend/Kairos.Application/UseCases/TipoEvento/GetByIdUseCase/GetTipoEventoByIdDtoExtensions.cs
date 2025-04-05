namespace Kairos.Application.UseCases.TipoEvento.GetByIdUseCase;
public static class GetTipoEventoDtoExtensions
{
    public static GetTipoEventoByIdDto ToDTO (this TipoEventoEntity entity)
    {
        return new GetTipoEventoByIdDto
        {
            Id = entity.Id,
            Nome = entity.Nome
        };
    }
    public static IEnumerable<GetTipoEventoByIdDto> ToDTO(this IEnumerable<TipoEventoEntity> dto)
    {
        return dto.Select(entity => entity.ToDTO());
    }
}
