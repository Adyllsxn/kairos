namespace Kairos.Infrastructure.Repositories;
public class EventosRepository(AppDbContext context) : IEventoRepository
{
    #region </Create>
        public async Task<ResponseModel<EventosEntity>> CreateAsync(EventosEntity entity, CancellationToken token)
        {
            try
            {
                if(entity == null)
                {
                    return new ResponseModel<EventosEntity>(null, 400, "Parâmetros não podem estar vazio.");
                }
                await context.Eventos.AddAsync(entity, token);
                return new ResponseModel<EventosEntity>(entity, 201, "Tipo de evento criado.");
            }
            catch (Exception ex)
            {
                return new ResponseModel<EventosEntity>(
                    null,
                    500,
                    $"Erro ao criar tipo de eveto. Erro {ex.Message}."
                );
            }
        }
    #endregion

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
