namespace Kairos.Presentation.Controllers;
[ApiController]
[Route("api/[controller]")]
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
}
