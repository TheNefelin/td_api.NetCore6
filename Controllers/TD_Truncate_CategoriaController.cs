using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [ApiKeyAuth]
    [Route("td-truncate-categoria")]
    [ApiController]
    public class TD_Truncate_CategoriaController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TD_Truncate_CategoriaController> _logger;

        public TD_Truncate_CategoriaController(
            ConexionBDContext context,
            ILogger<TD_Truncate_CategoriaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpDelete]
        [Route("")]
        public async Task<dynamic> TDCategoriaTruncate(
           CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDCategoriaTruncate(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
