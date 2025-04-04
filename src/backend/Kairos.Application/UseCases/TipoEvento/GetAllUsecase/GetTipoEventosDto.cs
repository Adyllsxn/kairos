namespace Kairos.Application.UseCases.TipoEvento.GetAllUsecase;
public class GetTipoEventosDto
{
    public int Id { get; set; }

    [Required]
    [StringLength(60, ErrorMessage = "O Nome deve ter 60 no máximo caracteres")]
    public string Nome { get; set; } = null!;
}
