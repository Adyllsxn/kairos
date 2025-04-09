namespace Kairos.Infrastructure.Repositories;
public class TipoEventoRepository(AppDbContext context) : ITipoEventoRepository
{
    #region </Create>
        public async Task<ResponseModel<TipoEventoEntity>> CreateAsync(TipoEventoEntity entity, CancellationToken token)
        {
            try
            {
                if(entity == null)
                {
                    return new ResponseModel<TipoEventoEntity>(null, 400, "Parâmetros não podem estar vazio.");
                }
                await context.TipoEventos.AddAsync(entity, token);
                return new ResponseModel<TipoEventoEntity>(entity, 201, "Tipo de evento criado.");
            }
            catch (Exception ex)
            {
                return new ResponseModel<TipoEventoEntity>(
                    null, 
                    500, 
                    $"Erro ao criar tipo de eveto. Erro {ex.Message}."
                    );
            }
        }
    #endregion

    #region </Delete>
        public async Task<ResponseModel<bool>> DeleteAsync(int entityId, CancellationToken token)
        {
            try
            {
                if (entityId <= 0)
                {
                    return new ResponseModel<bool>(false, 400, "ID deve ser maior que zero.");
                }
                var response = await context.TipoEventos.FindAsync(entityId, token);
                if (response == null)
                {
                    return new ResponseModel<bool>(false, 404, "ID não encontrado.");
                }
                context.TipoEventos.Remove(response);
                return new ResponseModel<bool>(true, 200, "Tipo de evento deletado");
            }
            catch (Exception ex)
            {
                return new ResponseModel<bool>(false, 500, $"Erro ao deletar tipo de evento. Erro {ex.Message}.");
            }
        }
    #endregion

    #region </GetAll>
    public async Task<ResponseModel<List<TipoEventoEntity>?>> GetAllAsync(CancellationToken token)
    {
        try
        {
            var response = await context.TipoEventos.AsNoTracking().ToListAsync(token);
            if (response == null || response.Count == 0)
            {
                return new ResponseModel<List<TipoEventoEntity>?>(null, 404, "Nenhum dado encontrado.");
            }

            return new ResponseModel<List<TipoEventoEntity>?>(response, 200, "Lista de tipo de eventos.");
        }
        catch (Exception ex)
        {
            return new ResponseModel<List<TipoEventoEntity>?>(null, 500, $"Erro ao obter tipo de evento. Erro {ex.Message}.");
        }
    }
    #endregion

    #region </GetById>
        public async Task<ResponseModel<TipoEventoEntity?>> GetByIdAsync(int entityId, CancellationToken token)
        {
            try
            {
                if(entityId <= 0)
                {
                    return new ResponseModel<TipoEventoEntity?>(null, 400, "ID deve ser maior que zero.");
                }
                var response = await context.TipoEventos.FindAsync(entityId, token);
                if(response == null)
                {
                    return new ResponseModel<TipoEventoEntity?>(null, 404, "ID não encontrado.");
                }
                return new ResponseModel<TipoEventoEntity?>(response, 200, "Dados encontrado.");
            }
            catch (Exception ex)
            {
                return new ResponseModel<TipoEventoEntity?>(null, 500, $"Erro ao obter categoria. Erro {ex.Message}");
            }
        }
    #endregion

    #region </Search>
        public async Task<ResponseModel<List<TipoEventoEntity>?>> SearchAsync(Expression<Func<TipoEventoEntity, bool>> expression, string entity, CancellationToken token)
        {
            try
            {
                if(entity == null)
                {
                    return new ResponseModel<List<TipoEventoEntity>?>(null, 400, "Parâmetros não podem estar vazio.");
                }
                var response = await context.TipoEventos.Where(expression).ToListAsync(token);
                if(response == null || response.Count == 0)
                {
                    return new ResponseModel<List<TipoEventoEntity>?>(null, 404, "Nenhum dado encontrado.");
                }

                return new ResponseModel<List<TipoEventoEntity>?>(response, 200, "Dados encontrado.");
            }
            catch (Exception ex)
            {
                return new ResponseModel<List<TipoEventoEntity>?>(null, 500, $"Erro ao obter categoria. Erro {ex.Message}");
            }
        }
    #endregion

    #region </Update>
        public async Task<ResponseModel<TipoEventoEntity>> UpdateAsync(TipoEventoEntity entity, CancellationToken token)
        {
            try
            {
                if(entity == null)
                {
                    return new ResponseModel<TipoEventoEntity>(null, 400, "Parâmetros não podem estar vazio.");
                }
                var response = await context.TipoEventos.FindAsync(entity.Id);
                if(response == null)
                {
                    return new ResponseModel<TipoEventoEntity>(null, 404, "ID não encontrado.");
                }
                context.Entry(response).CurrentValues.SetValues(entity);
                return new ResponseModel<TipoEventoEntity>(response, 200, "tipo de evento alterado.");
            }
            catch (Exception ex)
            {
                return new ResponseModel<TipoEventoEntity>(null, 500, $"Erro ao obter categoria. Erro {ex.Message}");
            }
        }
    #endregion
}
