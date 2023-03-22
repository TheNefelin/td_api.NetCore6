using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;
using td_api.NetCore6.Models;

namespace td_api.NetCore6.Controllers
{
    [Route("f1-carrera")]
    [ApiController]
    public class F1_CarreraController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<F1_CarreraController> _logger;

        public F1_CarreraController(
            ConexionBDContext context,
            ILogger<F1_CarreraController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> SpCarrera(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpCarrera(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPost]
        [Route("")]
        public async Task<dynamic> SpCarreraSet(
            F1_Carrera tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpCarreraSet(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
