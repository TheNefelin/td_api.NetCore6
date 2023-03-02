using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [ApiKeyAuth]
    [Route("td-sucursal")]
    [ApiController]
    public class TD_Truncate_SucursalController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TD_Truncate_SucursalController> _logger;

        public TD_Truncate_SucursalController(
            ConexionBDContext context,
            ILogger<TD_Truncate_SucursalController> logger)
        {
            _context = context;
            _logger = logger;
        }


        [HttpDelete]
        [Route("")]
        public async Task<dynamic> TDSucursalTruncate(
           CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDSucursalTruncate(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
