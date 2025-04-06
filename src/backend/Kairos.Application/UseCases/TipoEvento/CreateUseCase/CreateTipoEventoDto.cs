namespace Kairos.Application.UseCases.TipoEvento.CreateUseCase;
public sealed class CreateTipoEventoDto
{
    [Required]
    [StringLength(60, ErrorMessage = "O Nome deve ter 60 no máximo caracteres")]
    public string Nome { get; set; } = null!;
}
