namespace Kairos.Infrastructure.Repositories;
public class EventosRepository : IEventoRepository
{
    public Task<ResponseModel<EventosEntity>> CreateAsync(EventosEntity entity, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<bool>> DeleteAsync(int entityId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<List<EventosEntity>?>> GetAllAsync(PagedRequest request, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<EventosEntity?>> GetByIdAsync(int entityId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<List<EventosEntity>?>> SearchAsync(Expression<Func<EventosEntity, bool>> expression, string entity, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<EventosEntity>> UpdateAsync(EventosEntity entity, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}
