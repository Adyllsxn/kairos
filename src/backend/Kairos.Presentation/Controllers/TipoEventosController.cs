namespace Kairos.Presentation.Controllers;
[ApiController]
[Route("v1/")]
public class TipoEventosController(ITipoEventoService service) : ControllerBase
{
    #region </GetAll>
        [HttpGet("TipoEventos"), EndpointSummary("Obter todos tipo de eventos")]
        public async Task<IActionResult> GetAllAsync(CancellationToken token)
        {
            var response = await service.GetAllAsync(token);
            return Ok(response);
        }
    #endregion

    #region </GetById>
        [HttpGet("TipoEventoById"), EndpointSummary("Obter tipos de eventos por Id")]
        public async Task<IActionResult> GetByIdAsync(int tipoEventoById, CancellationToken token)
        {
            var response = await service.GetByIdAsync(tipoEventoById,token);
            return Ok(response);
        }
    #endregion

    #region </Search>
        [HttpGet("SearchTipoEvento"), EndpointSummary("Pesquisar o tipo de evento")]
        public async Task<IActionResult> SearchAsync(string search, CancellationToken token)
        {
            var response = await service.SearchAsync(search,token);
            return Ok(response);
        }
    #endregion

    #region </Create>
        [HttpPost("CreateipoEvento"), EndpointSummary("Adicionar o tipo de evento")]
        public async Task<IActionResult> CreateAsync(CreateTipoEventoDto dto, CancellationToken token)
        {
            var response = await service.CreateAsync(dto,token);
            return Ok(response);
        }
    #endregion

    #region </Delete>
        [HttpDelete("DeleteTipoEvento"), EndpointSummary("excluir o tipo de evento")]
        public async Task<IActionResult> DeleteAsync(DeleteTipoEventoDto dto, CancellationToken token)
        {
            var response = await service.DeleteAsync(dto,token);
            return Ok(response);
        }
    #endregion

    #region </Update>
        [HttpPut("UpdateTipoEvento"), EndpointSummary("aditar o tipo de evento")]
        public async Task<IActionResult> UpdateAsync(UpdateTipoEventoDto dto, CancellationToken token)
        {
            var response = await service.UpdateAsync(dto,token);
            return Ok(response);
        }
    #endregion
}
