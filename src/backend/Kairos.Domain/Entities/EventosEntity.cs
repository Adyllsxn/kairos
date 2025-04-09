namespace Kairos.Domain.Entities;
public sealed class EventosEntity: EntityBase, IAgragateRoot
{
    public string Nome { get; set; } = null!;
    public string Descricao { get; set; } = null!;
    public DateTime DataHora { get; set; }
    public string Local { get; set; } = null!;
    public string Foto { get; set; } = null!;
    public int TipoEventoId { get; set; }

    [JsonIgnore]
    public TipoEventoEntity TipoEvento { get; set; } = null!;

    private EventosEntity(){}
    public EventosEntity(int id, string nome, string descricao, DateTime datahora, string local, string foto, int tipoEventoId)
    {
        DomainExceptionValidation.When(id <= 0 , "ID deve ser maior que zero.");
        Id = id;
        ValiadationDomain(nome, descricao, datahora, local, foto, tipoEventoId);
    }
    public EventosEntity(string nome, string descricao, DateTime datahora, string local, string foto, int tipoEventoId)
    {
        ValiadationDomain(nome, descricao, datahora, local, foto, tipoEventoId);
    }
    public void Update(string nome, string descricao, DateTime datahora, string local, string foto, int tipoEventoId)
    {
        ValiadationDomain(nome, descricao, datahora, local, foto, tipoEventoId);
    }
    public void ValiadationDomain(string nome, string descricao, DateTime datahora, string local, string foto, int tipoEventoId)
    {
        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(nome), "Nome é obrigatório.");
        DomainExceptionValidation.When(nome.Length > 100, "Nome deve ter no máximo 60 caracteres.");

        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(descricao), "Descrição é obrigatório.");
        DomainExceptionValidation.When(descricao.Length < 3, "Descrição deve ter no mínimo 3 caracteres.");

        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(local), "Local é obrigatório.");
        DomainExceptionValidation.When(local.Length < 3, "Local deve ter no mínimo 3 caracteres.");

        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(foto), "Foto é obrigatório.");
        DomainExceptionValidation.When(foto.Length < 1, "Foto deve ter no mínimo 1 caracteres.");

        DomainExceptionValidation.When(tipoEventoId <= 0 , "ID do tipo de eventos deve ser maior que zero.");


        Nome = nome;
        Descricao = descricao;
        DataHora = datahora;
        Local = local;
        Foto = foto;
        TipoEventoId = tipoEventoId;
    }
}
