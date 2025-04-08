namespace Kairos.Domain.Abstractions.Interfaces;
public interface IEventoRepository : IRepository<EventosEntity>
{
    Task<ResponseModel<EventosEntity>> CreateAsync (EventosEntity entity, CancellationToken token);
    Task<ResponseModel<bool>> DeleteAsync (int entityId, CancellationToken token);
    Task<ResponseModel<EventosEntity?>> GetByIdAsync (int entityId, CancellationToken token);
    Task<PagedList<List<EventosEntity>?>> GetAllAsync (PagedRequest request, CancellationToken token);
    Task<ResponseModel<EventosEntity>> UpdateAsync (EventosEntity entity, CancellationToken token);
    Task<PagedList<List<EventosEntity>?>> SearchAsync (Expression<Func<EventosEntity, bool>> expression, string entity, CancellationToken token);
}
