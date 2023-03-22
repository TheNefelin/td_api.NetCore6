using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [Route("f1-reset")]
    [ApiController]
    public class F1_ResetController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<F1_ResetController> _logger;

        public F1_ResetController(
            ConexionBDContext context,
            ILogger<F1_ResetController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpDelete]
        [Route("")]
        public async Task<dynamic> SpReset(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpReset(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
