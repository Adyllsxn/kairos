namespace Kairos.Presentation.Controllers;
[ApiController]
[Route("v1/")]
public class TipoEventosController(ITipoEventoService service) : ControllerBase
{
    #region </GetAll>
        [HttpGet("TipoEventos"), EndpointSummary("Obter todos eventos")]
        public async Task<IActionResult> GetAllAsync(CancellationToken token)
        {
            var response = await service.GetAllAsync(token);
            return Ok(response);
        }
    #endregion

    #region </GetById>
        [HttpGet("TipoEventoById"), EndpointSummary("Obter todos eventos por Id")]
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
}
