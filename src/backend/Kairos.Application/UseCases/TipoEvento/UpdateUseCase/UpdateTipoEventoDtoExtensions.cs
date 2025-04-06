namespace Kairos.Application.UseCases.TipoEvento.UpdateUseCase;
public static class UpdateTipoEventoDtoExtensions
{
    public static TipoEventoEntity ToEntity(this UpdateTipoEventoDto dto)
        => new(dto.Id, dto.Nome);
}
