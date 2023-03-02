using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [ApiKeyAuth]
    [Route("td-truncate-producto")]
    [ApiController]
    public class TD_Truncate_ProductoController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TD_Truncate_ProductoController> _logger;

        public TD_Truncate_ProductoController(
            ConexionBDContext context,
            ILogger<TD_Truncate_ProductoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpDelete]
        [Route("")]
        public async Task<dynamic> TDProductoTruncate(
           CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoTruncate(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
