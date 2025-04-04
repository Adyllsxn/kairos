namespace Kairos.Domain.Abstractions.Interfaces;
public interface ITipoEventoRepository : IRepository<TipoEventoEntity>
{
    Task<ResponseModel<TipoEventoEntity>> CreateAsync (TipoEventoEntity entity, CancellationToken token);
    Task<ResponseModel<bool>> DeleteAsync (int entityId, CancellationToken token);
    Task<ResponseModel<TipoEventoEntity?>> GetByIdAsync (int entityId, CancellationToken token);
    Task<ResponseModel<List<TipoEventoEntity>?>> GetAllAsync (CancellationToken token);
    Task<ResponseModel<TipoEventoEntity>> UpdateAsync (TipoEventoEntity entity, CancellationToken token);
    Task<ResponseModel<List<TipoEventoEntity>?>> SearchAsync (Expression<Func<TipoEventoEntity, bool>> expression, string entity, CancellationToken token);
}
