namespace Kairos.Infrastructure.Context;
public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CommitAsync()
    {
        await context.SaveChangesAsync();
    }
}
