namespace Kairos.Application.UseCases.TipoEvento.CreateUseCase;
public static class CreateTipoEventoDtoExtensions
{
    public static TipoEventoEntity ToEntity(this CreateTipoEventoDto dto)
        => new(dto.Nome);
}
