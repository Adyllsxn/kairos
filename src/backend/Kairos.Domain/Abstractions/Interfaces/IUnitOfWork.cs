namespace Kairos.Domain.Abstractions.Interfaces;
public interface IUnitOfWork
{
    Task CommitAsync();
}
