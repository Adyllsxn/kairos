namespace Kairos.Domain.Entities;
public sealed class TipoEventoEntity: EntityBase, IAgragateRoot
{
    public string Nome { get; private set; } = null!;

    [JsonConstructor]
    public TipoEventoEntity(){}
    public TipoEventoEntity(int id, string nome)
    {
        DomainExceptionValidation.When(Id <=0 , "ID deve ser maior que zero.");
        Id = id;
        ValidationDomain(nome);
    }
    public TipoEventoEntity(string nome)
    {
        ValidationDomain(nome);
    }
    public void UpDate(string nome)
    {
        ValidationDomain(nome);
    }
    public void ValidationDomain(string nome)
    {
        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(nome), "Nome é obrigatório.");
        DomainExceptionValidation.When(nome.Length >= 60, "Nome deve ter menor de 60 caracteres.");

        Nome = nome;
    }
}
