namespace Kairos.Application.UseCases.TipoEvento.UpdateUseCase;
public class UpdateTipoEventoDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(60, ErrorMessage = "O Nome deve ter no máximo 60 caracteres")]
    public string Nome { get; set; } = null!;
}
