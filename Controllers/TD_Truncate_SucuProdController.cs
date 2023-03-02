using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [ApiKeyAuth]
    [Route("td-truncate-sucu-prod")]
    [ApiController]
    public class TD_Truncate_SucuProdController
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TD_Truncate_SucuProdController> _logger;

        public TD_Truncate_SucuProdController(
            ConexionBDContext context,
            ILogger<TD_Truncate_SucuProdController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpDelete]
        [Route("")]
        public async Task<dynamic> TDSucuProdTruncate(
           CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDSucuProdTruncate(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
